using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathWorks.MATLAB.NET.Arrays;
using FuncMedDetect;

namespace ConsoleMedDetect
{
    class Program
    {
        static void Main(string[] args)
        {
            double factor1;
            double factor2;
            double threshold1;
            double threshold2;
            string folder;
            string file;

            if (args.Length != 6)
            {
                ///////////////////////////////////////////////////////////////
                // Default settings
                ///////////////////////////////////////////////////////////////
                factor1 = 0.8;
                factor2 = 0.8;
                threshold1 = 0;
                threshold2 = 0.25;
                folder = @"D:\Projects\MED\Matlab\SourceCode\";
                file = @"lc_input.tif";
            }
            else
            {
                ///////////////////////////////////////////////////////////////
                // Command line parameters
                ///////////////////////////////////////////////////////////////
                double.TryParse(args[0], out factor1);
                double.TryParse(args[1], out factor2);
                double.TryParse(args[2], out threshold1);
                double.TryParse(args[3], out threshold2);
                folder = args[4];
                file = args[5];

                factor1 = 0.8;
                factor2 = 0.8;
                threshold1 = 0;
                threshold2 = 0.25;
                folder = @"D:\Projects\MED\Matlab\SourceCode\";
                file = @"lc_input.tif";
            }

            Console.WriteLine("Please wait...");
            double[] _threshold = new double[] { threshold1, threshold2 };            
            MWNumericArray threshold = new MWNumericArray(_threshold);
            MWNumericArray fudgeFactor1 = new MWNumericArray(factor1);
            MWNumericArray fudgeFactor2 = new MWNumericArray(factor2);
            MWCharArray path = new MWCharArray(folder);
            MWCharArray filename = new MWCharArray(file);

            ClassMedDetect medDetect = new ClassMedDetect();            
            MWArray MWResult = medDetect.func_med_detect(path, filename, threshold, fudgeFactor1, fudgeFactor2);

            Console.Clear();
            Console.WriteLine("The calculation successfully completed");
            Console.WriteLine("======================================");            
            Console.WriteLine(String.Format("Total objects found: {0}", (double)((MWNumericArray)MWResult[1])));
            Console.WriteLine(String.Format("Total area calculated: {0}", (double)((MWNumericArray)MWResult[2])));
            Console.WriteLine(String.Format("Selected objects found: {0}", (double)((MWNumericArray)MWResult[3])));
            Console.WriteLine(String.Format("Selected area calculated: {0}", (double)((MWNumericArray)MWResult[4])));
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
