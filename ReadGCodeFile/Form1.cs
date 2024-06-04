using System;
using System.Windows.Forms.Design;
using ReadGCodeFile.Services;

namespace ReadGCodeFile
{
    public partial class Form1 : Form
    {

        int? index;
        int index2;
        bool isG54;
        string NewLine;
        string sG54 = "G54";

        servicesReadFile bakalımOldumu = new servicesReadFile();


        public Form1()
        {
            InitializeComponent();

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            Char[] test;
            Char[] cG54 = sG54.ToCharArray();

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Temp\GCode",
                Title = "Select G Code",

                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".cnc,.gcode",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,

            };
            


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.SafeFileName;
                var fileStream = openFileDialog1.OpenFile();

                NewLine = bakalımOldumu.FileReading(fileStream,"G54","G54 X5151515");

                lstWriterBox.Items.Add(NewLine);
               
                 

            }

        }

        private void btnCreateGCode_Click(object sender, EventArgs e)
        {
            var fileStream = openFileDialog1.OpenFile();
            using (StreamWriter write = new StreamWriter(fileStream))
            {



            };
        }
    }
}

