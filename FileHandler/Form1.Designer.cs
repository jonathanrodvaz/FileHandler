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
            textWrite = new TextBox();
            label10 = new Label();
            btnWrite = new Button();
            btnRead = new Button();
            label11 = new Label();
            txtRead = new TextBox();
            btnFind = new Button();
            label12 = new Label();
            txtFind = new TextBox();
            btnUpdate = new Button();
            label13 = new Label();
            txtUpdate = new TextBox();
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
            btnOpenFile.Location = new Point(260, 431);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(154, 23);
            btnOpenFile.TabIndex = 17;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtSelectedFile
            // 
            txtSelectedFile.Location = new Point(88, 432);
            txtSelectedFile.Name = "txtSelectedFile";
            txtSelectedFile.Size = new Size(166, 23);
            txtSelectedFile.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 438);
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
            btnRenameFile.Location = new Point(260, 460);
            btnRenameFile.Name = "btnRenameFile";
            btnRenameFile.Size = new Size(154, 23);
            btnRenameFile.TabIndex = 20;
            btnRenameFile.Text = "Rename";
            btnRenameFile.UseVisualStyleBackColor = true;
            btnRenameFile.Click += btnRenameFile_Click;
            // 
            // txtRenameFile
            // 
            txtRenameFile.Location = new Point(88, 461);
            txtRenameFile.Name = "txtRenameFile";
            txtRenameFile.Size = new Size(166, 23);
            txtRenameFile.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 467);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 18;
            label9.Text = "Rename";
            // 
            // textWrite
            // 
            textWrite.Location = new Point(25, 534);
            textWrite.Multiline = true;
            textWrite.Name = "textWrite";
            textWrite.Size = new Size(188, 131);
            textWrite.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(88, 514);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 22;
            label10.Text = "Write";
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(25, 671);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(188, 23);
            btnWrite.TabIndex = 23;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(241, 671);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(188, 23);
            btnRead.TabIndex = 26;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(308, 514);
            label11.Name = "label11";
            label11.Size = new Size(38, 17);
            label11.TabIndex = 25;
            label11.Text = "Read";
            // 
            // txtRead
            // 
            txtRead.Location = new Point(241, 534);
            txtRead.Multiline = true;
            txtRead.Name = "txtRead";
            txtRead.Size = new Size(188, 131);
            txtRead.TabIndex = 24;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(480, 671);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(188, 23);
            btnFind.TabIndex = 29;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(557, 514);
            label12.Name = "label12";
            label12.Size = new Size(35, 17);
            label12.TabIndex = 28;
            label12.Text = "Find";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(480, 534);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(188, 131);
            txtFind.TabIndex = 27;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(702, 671);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 23);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(765, 514);
            label13.Name = "label13";
            label13.Size = new Size(52, 17);
            label13.TabIndex = 31;
            label13.Text = "Update";
            // 
            // txtUpdate
            // 
            txtUpdate.Location = new Point(702, 534);
            txtUpdate.Multiline = true;
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(188, 131);
            txtUpdate.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 714);
            Controls.Add(btnUpdate);
            Controls.Add(label13);
            Controls.Add(txtUpdate);
            Controls.Add(btnFind);
            Controls.Add(label12);
            Controls.Add(txtFind);
            Controls.Add(btnRead);
            Controls.Add(label11);
            Controls.Add(txtRead);
            Controls.Add(btnWrite);
            Controls.Add(label10);
            Controls.Add(textWrite);
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
        private TextBox textWrite;
        private Label label10;
        private Button btnWrite;
        private Button btnRead;
        private Label label11;
        private TextBox txtRead;
        private Button btnFind;
        private Label label12;
        private TextBox txtFind;
        private Button btnUpdate;
        private Label label13;
        private TextBox txtUpdate;
    }
}