namespace FileHandler
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
            cboSystemDrives = new ComboBox();
            txtSystemDetails = new TextBox();
            label1 = new Label();
            txtNewDirectory = new TextBox();
            btnCreateDirectory = new Button();
            btnNewSubdirectory = new Button();
            txtNewSubdirectory = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cboDirectoryFiles = new ComboBox();
            btnShowDirectoryFiles = new Button();
            panel1 = new Panel();
            btnCopyDirectory = new Button();
            txtCopyDirectoryDestination = new TextBox();
            label6 = new Label();
            txtCopyDirectorySource = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnNewFile = new Button();
            txtNewFile = new TextBox();
            label7 = new Label();
            btnOpenFile = new Button();
            txtSelectedFile = new TextBox();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnRenameFile = new Button();
            txtRenameFile = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            label11 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label12 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            label13 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboSystemDrives
            // 
            cboSystemDrives.FormattingEnabled = true;
            cboSystemDrives.Location = new Point(12, 45);
            cboSystemDrives.Name = "cboSystemDrives";
            cboSystemDrives.Size = new Size(299, 23);
            cboSystemDrives.TabIndex = 0;
            cboSystemDrives.SelectedIndexChanged += cboSystemDrives_SelectedIndexChanged;
            // 
            // txtSystemDetails
            // 
            txtSystemDetails.Location = new Point(12, 74);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(299, 313);
            txtSystemDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 45);
            label1.Name = "label1";
            label1.Size = new Size(188, 17);
            label1.TabIndex = 2;
            label1.Text = "New Directory (include path)";
            // 
            // txtNewDirectory
            // 
            txtNewDirectory.Location = new Point(535, 45);
            txtNewDirectory.Name = "txtNewDirectory";
            txtNewDirectory.Size = new Size(166, 23);
            txtNewDirectory.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(733, 43);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(154, 23);
            btnCreateDirectory.TabIndex = 4;
            btnCreateDirectory.Text = "Create directory";
            btnCreateDirectory.UseVisualStyleBackColor = true;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // btnNewSubdirectory
            // 
            btnNewSubdirectory.Location = new Point(733, 99);
            btnNewSubdirectory.Name = "btnNewSubdirectory";
            btnNewSubdirectory.Size = new Size(154, 23);
            btnNewSubdirectory.TabIndex = 7;
            btnNewSubdirectory.Text = "Create subdirectory";
            btnNewSubdirectory.UseVisualStyleBackColor = true;
            btnNewSubdirectory.Click += btnNewSubdirectory_Click;
            // 
            // txtNewSubdirectory
            // 
            txtNewSubdirectory.Location = new Point(535, 99);
            txtNewSubdirectory.Name = "txtNewSubdirectory";
            txtNewSubdirectory.Size = new Size(166, 23);
            txtNewSubdirectory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 99);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 5;
            label2.Text = "New Subdirectory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(329, 151);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 8;
            label3.Text = "Show Directory Details";
            // 
            // cboDirectoryFiles
            // 
            cboDirectoryFiles.FormattingEnabled = true;
            cboDirectoryFiles.Location = new Point(535, 151);
            cboDirectoryFiles.Name = "cboDirectoryFiles";
            cboDirectoryFiles.Size = new Size(166, 23);
            cboDirectoryFiles.TabIndex = 9;
            // 
            // btnShowDirectoryFiles
            // 
            btnShowDirectoryFiles.Location = new Point(733, 151);
            btnShowDirectoryFiles.Name = "btnShowDirectoryFiles";
            btnShowDirectoryFiles.Size = new Size(154, 23);
            btnShowDirectoryFiles.TabIndex = 10;
            btnShowDirectoryFiles.Text = "Show Directory Files";
            btnShowDirectoryFiles.UseVisualStyleBackColor = true;
            btnShowDirectoryFiles.Click += btnShowDirectoryFiles_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyDirectory);
            panel1.Controls.Add(txtCopyDirectoryDestination);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCopyDirectorySource);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(329, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 144);
            panel1.TabIndex = 11;
            // 
            // btnCopyDirectory
            // 
            btnCopyDirectory.Location = new Point(404, 58);
            btnCopyDirectory.Name = "btnCopyDirectory";
            btnCopyDirectory.Size = new Size(134, 50);
            btnCopyDirectory.TabIndex = 14;
            btnCopyDirectory.Text = "Copy";
            btnCopyDirectory.UseVisualStyleBackColor = true;
            btnCopyDirectory.Click += btnCopyDirectory_Click;
            // 
            // txtCopyDirectoryDestination
            // 
            txtCopyDirectoryDestination.Location = new Point(226, 91);
            txtCopyDirectoryDestination.Name = "txtCopyDirectoryDestination";
            txtCopyDirectoryDestination.Size = new Size(166, 23);
            txtCopyDirectoryDestination.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 91);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 12;
            label6.Text = "Destination";
            // 
            // txtCopyDirectorySource
            // 
            txtCopyDirectorySource.Location = new Point(226, 50);
            txtCopyDirectorySource.Name = "txtCopyDirectorySource";
            txtCopyDirectorySource.Size = new Size(166, 23);
            txtCopyDirectorySource.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 10;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(160, 30);
            label4.TabIndex = 9;
            label4.Text = "Copy Directory";
            // 
            // btnNewFile
            // 
            btnNewFile.Location = new Point(736, 368);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(154, 23);
            btnNewFile.TabIndex = 14;
            btnNewFile.Text = "Create file";
            btnNewFile.UseVisualStyleBackColor = true;
            btnNewFile.Click += btnNewFile_Click;
            // 
            // txtNewFile
            // 
            txtNewFile.Location = new Point(538, 370);
            txtNewFile.Name = "txtNewFile";
            txtNewFile.Size = new Size(166, 23);
            txtNewFile.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(332, 370);
            label7.Name = "label7";
            label7.Size = new Size(152, 17);
            label7.TabIndex = 12;
            label7.Text = "New File (include path)";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(258, 441);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(154, 23);
            btnOpenFile.TabIndex = 17;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtSelectedFile
            // 
            txtSelectedFile.Location = new Point(86, 442);
            txtSelectedFile.Name = "txtSelectedFile";
            txtSelectedFile.Size = new Size(166, 23);
            txtSelectedFile.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 448);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 15;
            label8.Text = "Select file";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRenameFile
            // 
            btnRenameFile.Location = new Point(258, 470);
            btnRenameFile.Name = "btnRenameFile";
            btnRenameFile.Size = new Size(154, 23);
            btnRenameFile.TabIndex = 20;
            btnRenameFile.Text = "Rename";
            btnRenameFile.UseVisualStyleBackColor = true;
            btnRenameFile.Click += btnRenameFile_Click;
            // 
            // txtRenameFile
            // 
            txtRenameFile.Location = new Point(86, 471);
            txtRenameFile.Name = "txtRenameFile";
            txtRenameFile.Size = new Size(166, 23);
            txtRenameFile.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 477);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 18;
            label9.Text = "Rename";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 534);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 131);
            textBox1.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(129, 514);
            label10.Name = "label10";
            label10.Size = new Size(57, 17);
            label10.TabIndex = 22;
            label10.Text = "Rename";
            // 
            // button1
            // 
            button1.Location = new Point(86, 679);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 23;
            button1.Text = "Rename";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(391, 679);
            button2.Name = "button2";
            button2.Size = new Size(154, 23);
            button2.TabIndex = 26;
            button2.Text = "Rename";
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(434, 514);
            label11.Name = "label11";
            label11.Size = new Size(57, 17);
            label11.TabIndex = 25;
            label11.Text = "Rename";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 534);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 131);
            textBox2.TabIndex = 24;
            // 
            // button3
            // 
            button3.Location = new Point(696, 679);
            button3.Name = "button3";
            button3.Size = new Size(154, 23);
            button3.TabIndex = 29;
            button3.Text = "Rename";
            button3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(739, 514);
            label12.Name = "label12";
            label12.Size = new Size(57, 17);
            label12.TabIndex = 28;
            label12.Text = "Rename";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(622, 534);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 131);
            textBox3.TabIndex = 27;
            // 
            // button4
            // 
            button4.Location = new Point(1001, 679);
            button4.Name = "button4";
            button4.Size = new Size(154, 23);
            button4.TabIndex = 32;
            button4.Text = "Rename";
            button4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1044, 514);
            label13.Name = "label13";
            label13.Size = new Size(57, 17);
            label13.TabIndex = 31;
            label13.Text = "Rename";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(927, 534);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 131);
            textBox4.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 714);
            Controls.Add(button4);
            Controls.Add(label13);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(btnRenameFile);
            Controls.Add(txtRenameFile);
            Controls.Add(label9);
            Controls.Add(btnOpenFile);
            Controls.Add(txtSelectedFile);
            Controls.Add(label8);
            Controls.Add(btnNewFile);
            Controls.Add(txtNewFile);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnShowDirectoryFiles);
            Controls.Add(cboDirectoryFiles);
            Controls.Add(label3);
            Controls.Add(btnNewSubdirectory);
            Controls.Add(txtNewSubdirectory);
            Controls.Add(label2);
            Controls.Add(btnCreateDirectory);
            Controls.Add(txtNewDirectory);
            Controls.Add(label1);
            Controls.Add(txtSystemDetails);
            Controls.Add(cboSystemDrives);
            Name = "Form1";
            Text = "File Handler";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSystemDrives;
        private TextBox txtSystemDetails;
        private Label label1;
        private TextBox txtNewDirectory;
        private Button btnCreateDirectory;
        private Button btnNewSubdirectory;
        private TextBox txtNewSubdirectory;
        private Label label2;
        private Label label3;
        private ComboBox cboDirectoryFiles;
        private Button btnShowDirectoryFiles;
        private Panel panel1;
        private TextBox txtCopyDirectorySource;
        private Label label5;
        private Label label4;
        private TextBox txtCopyDirectoryDestination;
        private Label label6;
        private Button btnCopyDirectory;
        private Button btnNewFile;
        private TextBox txtNewFile;
        private Label label7;
        private Button btnOpenFile;
        private TextBox txtSelectedFile;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button btnRenameFile;
        private TextBox txtRenameFile;
        private Label label9;
        private TextBox textBox1;
        private Label label10;
        private Button button1;
        private Button button2;
        private Label label11;
        private TextBox textBox2;
        private Button button3;
        private Label label12;
        private TextBox textBox3;
        private Button button4;
        private Label label13;
        private TextBox textBox4;
    }
}