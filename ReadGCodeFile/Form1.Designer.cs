namespace ReadGCodeFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            lstWriterBox = new ListBox();
            btnCreateGCode = new Button();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 12);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(165, 42);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "OpenFile";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(521, 244);
            listBox1.TabIndex = 2;
            // 
            // lstWriterBox
            // 
            lstWriterBox.FormattingEnabled = true;
            lstWriterBox.ItemHeight = 15;
            lstWriterBox.Location = new Point(576, 111);
            lstWriterBox.Name = "lstWriterBox";
            lstWriterBox.Size = new Size(430, 244);
            lstWriterBox.TabIndex = 3;
            // 
            // btnCreateGCode
            // 
            btnCreateGCode.Location = new Point(600, 15);
            btnCreateGCode.Name = "btnCreateGCode";
            btnCreateGCode.Size = new Size(163, 39);
            btnCreateGCode.TabIndex = 4;
            btnCreateGCode.Text = "Create New G Code";
            btnCreateGCode.UseVisualStyleBackColor = true;
            btnCreateGCode.Click += btnCreateGCode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 536);
            Controls.Add(btnCreateGCode);
            Controls.Add(lstWriterBox);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox lstWriterBox;
        private Button btnCreateGCode;
    }
}
