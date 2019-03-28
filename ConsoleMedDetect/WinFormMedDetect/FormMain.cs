using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using MathWorks.MATLAB.NET.Arrays;
using FuncMedDetect;
using System.Globalization;

namespace WinFormMedDetect
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = @"D:\Projects\MED\Matlab\InputData\";
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    textBoxPath.Text = folderDialog.SelectedPath;
                    string[] files = Directory.GetFiles(folderDialog.SelectedPath);
                    listBoxImages.Items.Clear();
                    listBoxImages.Items.AddRange(files);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ((listBoxImages.SelectedItem == null) || String.IsNullOrEmpty(listBoxImages.SelectedItem.ToString()))
                return;

            Cursor.Current = Cursors.WaitCursor;

            if (File.Exists("Ic_out.png"))
                File.Delete("Ic_out.png");

            pictureBoxResult.Image = null;

            double factor1;
            double factor2;
            double threshold1;
            double threshold2;
            string folder;
            string file;

            double.TryParse(textBoxFactor1.Text, out factor1);
            double.TryParse(textBoxFactor2.Text, out factor2);
            double.TryParse(textBoxThreshold1.Text, out threshold1);
            double.TryParse(textBoxThreshold2.Text, out threshold2);

            folder = System.IO.Path.GetDirectoryName(listBoxImages.SelectedItem.ToString()) + @"\";
            file = System.IO.Path.GetFileName(listBoxImages.SelectedItem.ToString());

            double[] _threshold = new double[] { threshold1, threshold2 };
            MWNumericArray threshold = new MWNumericArray(_threshold);
            MWNumericArray fudgeFactor1 = new MWNumericArray(factor1);
            MWNumericArray fudgeFactor2 = new MWNumericArray(factor2);
            MWCharArray path = new MWCharArray(folder);
            MWCharArray filename = new MWCharArray(file);

            ClassMedDetect medDetect = new ClassMedDetect();
            MWArray MWResult = medDetect.func_med_detect(path, filename, threshold, fudgeFactor1, fudgeFactor2);

            pictureBoxResult.Image = Image.FromFile("Ic_out.png");

            labelCautnTotal.Text = String.Format("Кол-во обнаруженных объектов: {0}", (double)((MWNumericArray)MWResult[1]));
            labelSquareTotal.Text = String.Format("Общая площадь объектов:: {0}", (double)((MWNumericArray)MWResult[2]));
            labelCountSelected.Text = String.Format("Кол-во выделенных объектов:: {0}", (double)((MWNumericArray)MWResult[3]));
            labelSquareSelected.Text = String.Format("Площадь выделенных объектов: {0}", (double)((MWNumericArray)MWResult[4]));

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Расчет закончен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxSource.Image = Image.FromFile(listBoxImages.SelectedItem.ToString());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
                pictureBoxResult.Image.Save(saveDialog.FileName);
        }
    }
}
