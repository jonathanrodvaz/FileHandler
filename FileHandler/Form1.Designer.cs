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
            txtSystemDetails.Size = new Size(299, 238);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
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
    }
}