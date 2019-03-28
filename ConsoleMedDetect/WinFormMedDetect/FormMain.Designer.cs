namespace WinFormMedDetect
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.labelImages = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.textBoxThreshold2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFactor2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThreshold1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFactor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSquareSelected = new System.Windows.Forms.Label();
            this.labelCountSelected = new System.Windows.Forms.Label();
            this.labelSquareTotal = new System.Windows.Forms.Label();
            this.labelCautnTotal = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.groupBoxSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxImages
            // 
            this.listBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 16;
            this.listBoxImages.Location = new System.Drawing.Point(12, 79);
            this.listBoxImages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(304, 212);
            this.listBoxImages.TabIndex = 0;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.Location = new System.Drawing.Point(9, 59);
            this.labelImages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(211, 16);
            this.labelImages.TabIndex = 1;
            this.labelImages.Text = "Исходные файлы изображений";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 31);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(251, 22);
            this.textBoxPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь к папке с изображениями";
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(270, 30);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(46, 23);
            this.buttonPath.TabIndex = 4;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSettings.Controls.Add(this.textBoxThreshold2);
            this.groupBoxSettings.Controls.Add(this.label4);
            this.groupBoxSettings.Controls.Add(this.textBoxFactor2);
            this.groupBoxSettings.Controls.Add(this.label5);
            this.groupBoxSettings.Controls.Add(this.textBoxThreshold1);
            this.groupBoxSettings.Controls.Add(this.label3);
            this.groupBoxSettings.Controls.Add(this.textBoxFactor1);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 298);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(304, 132);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки";
            // 
            // textBoxThreshold2
            // 
            this.textBoxThreshold2.Location = new System.Drawing.Point(198, 94);
            this.textBoxThreshold2.Name = "textBoxThreshold2";
            this.textBoxThreshold2.Size = new System.Drawing.Size(100, 22);
            this.textBoxThreshold2.TabIndex = 7;
            this.textBoxThreshold2.Text = "0.25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Threshold2";
            // 
            // textBoxFactor2
            // 
            this.textBoxFactor2.Location = new System.Drawing.Point(19, 94);
            this.textBoxFactor2.Name = "textBoxFactor2";
            this.textBoxFactor2.Size = new System.Drawing.Size(100, 22);
            this.textBoxFactor2.TabIndex = 5;
            this.textBoxFactor2.Text = "0.8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Factor2";
            // 
            // textBoxThreshold1
            // 
            this.textBoxThreshold1.Location = new System.Drawing.Point(198, 48);
            this.textBoxThreshold1.Name = "textBoxThreshold1";
            this.textBoxThreshold1.Size = new System.Drawing.Size(100, 22);
            this.textBoxThreshold1.TabIndex = 3;
            this.textBoxThreshold1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Threshold1";
            // 
            // textBoxFactor1
            // 
            this.textBoxFactor1.Location = new System.Drawing.Point(19, 48);
            this.textBoxFactor1.Name = "textBoxFactor1";
            this.textBoxFactor1.Size = new System.Drawing.Size(100, 22);
            this.textBoxFactor1.TabIndex = 1;
            this.textBoxFactor1.Text = "0.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factor1";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(12, 440);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 27);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonView.Location = new System.Drawing.Point(93, 440);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(111, 27);
            this.buttonView.TabIndex = 8;
            this.buttonView.Text = "ПРОСМОТР";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Location = new System.Drawing.Point(241, 440);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 27);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "ВЫХОД";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(323, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 455);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxSource);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(558, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оригинальное изображение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSource.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(538, 406);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 7;
            this.pictureBoxSource.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Controls.Add(this.labelSquareSelected);
            this.tabPage2.Controls.Add(this.labelCountSelected);
            this.tabPage2.Controls.Add(this.labelSquareTotal);
            this.tabPage2.Controls.Add(this.labelCautnTotal);
            this.tabPage2.Controls.Add(this.pictureBoxResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(558, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Результат обработки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Image = global::WinFormMedDetect.Properties.Resources.floppy;
            this.buttonSave.Location = new System.Drawing.Point(504, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(44, 38);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelSquareSelected
            // 
            this.labelSquareSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSquareSelected.AutoSize = true;
            this.labelSquareSelected.Location = new System.Drawing.Point(293, 400);
            this.labelSquareSelected.Name = "labelSquareSelected";
            this.labelSquareSelected.Size = new System.Drawing.Size(218, 16);
            this.labelSquareSelected.TabIndex = 12;
            this.labelSquareSelected.Text = "Площадь выделенных объектов:";
            // 
            // labelCountSelected
            // 
            this.labelCountSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountSelected.AutoSize = true;
            this.labelCountSelected.Location = new System.Drawing.Point(293, 380);
            this.labelCountSelected.Name = "labelCountSelected";
            this.labelCountSelected.Size = new System.Drawing.Size(204, 16);
            this.labelCountSelected.TabIndex = 11;
            this.labelCountSelected.Text = "Кол-во выделенных объектов:";
            // 
            // labelSquareTotal
            // 
            this.labelSquareTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSquareTotal.AutoSize = true;
            this.labelSquareTotal.Location = new System.Drawing.Point(7, 400);
            this.labelSquareTotal.Name = "labelSquareTotal";
            this.labelSquareTotal.Size = new System.Drawing.Size(178, 16);
            this.labelSquareTotal.TabIndex = 10;
            this.labelSquareTotal.Text = "Общая площадь объектов:";
            // 
            // labelCautnTotal
            // 
            this.labelCautnTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCautnTotal.AutoSize = true;
            this.labelCautnTotal.Location = new System.Drawing.Point(7, 380);
            this.labelCautnTotal.Name = "labelCautnTotal";
            this.labelCautnTotal.Size = new System.Drawing.Size(220, 16);
            this.labelCautnTotal.TabIndex = 9;
            this.labelCautnTotal.Text = "Кол-во обнаруженных объектов:";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResult.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(538, 367);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 8;
            this.pictureBoxResult.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 479);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelImages);
            this.Controls.Add(this.listBoxImages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MED";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxThreshold1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFactor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxThreshold2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFactor2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label labelCautnTotal;
        private System.Windows.Forms.Label labelSquareSelected;
        private System.Windows.Forms.Label labelCountSelected;
        private System.Windows.Forms.Label labelSquareTotal;
        private System.Windows.Forms.Button buttonSave;
    }
}

