namespace FileHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }


        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cboSystemDrives.Items.Add(drive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cboSystemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSystemDrives.SelectedItem.ToString();
                DriveInfo diskInfo = new DriveInfo(disk);
                var driveDetails = $@"
                    Drive: {disk} drive:

                    Total Size: {diskInfo.TotalSize}
                    Free space available: {diskInfo.AvailableFreeSpace}
                    Format: {diskInfo.DriveFormat}
                    Type: {diskInfo.DriveType}
                    ";
                txtSystemDetails.Text = driveDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Please, enter a path for the directory");
                if (!Directory.Exists(txtNewDirectory.Text))
                {
                    Directory.CreateDirectory(txtNewDirectory.Text);
                    MessageBox.Show("Directory Created");
                }
                else
                {
                    MessageBox.Show("Please, enter the full path of the new directory.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewSubdirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on New Directory");
                if (string.IsNullOrEmpty(txtNewSubdirectory.Text))
                    throw new Exception("Make sure you have included a path for the New Subdirectory");

                var directoryPath = txtNewDirectory.Text;
                var subdirInfo = new DirectoryInfo(directoryPath);

                subdirInfo.CreateSubdirectory(txtNewSubdirectory.Text);
                MessageBox.Show("Subdirectory has been created");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDirectoryFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on New Directory");

                var directory = txtNewDirectory.Text;
                var directoryInfo = new DirectoryInfo(directory);

                if (!directoryInfo.Exists)
                    throw new Exception("Directory doesn't exists");

                var subDirectories = directoryInfo.GetDirectories();
                foreach (var subdir in subDirectories)
                {
                    if (!cboDirectoryFiles.Items.Contains(subdir.Name))
                        cboDirectoryFiles.Items.Add(subdir.Name);
                }
                //Para traer todos los archivos utilizamos "*"
                var files = directoryInfo.GetFiles("*");
                foreach (var file in files)
                {
                    if (!cboDirectoryFiles.Items.Contains(file.Name))
                        cboDirectoryFiles.Items.Add(file.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopyDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCopyDirectorySource.Text) || string.IsNullOrEmpty(txtCopyDirectoryDestination.Text))
                    throw new Exception("Source and destionation fields should have values");

                var sourceDirectory = new DirectoryInfo(txtCopyDirectorySource.Text);
                var destinationDirectory = new DirectoryInfo(txtCopyDirectoryDestination.Text);
                CopyDirectory(sourceDirectory, destinationDirectory);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CopyDirectory(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {
            try
            {
                if (!sourceDirectory.Exists)
                    throw new Exception("Source directory doesn't exist");
                if (!destinationDirectory.Exists)
                    destinationDirectory.Create();

                var files = sourceDirectory.GetFiles();
                foreach (var file in files)
                {
                    file.CopyTo(Path.Combine(destinationDirectory.FullName, file.Name));
                }

                var directories = sourceDirectory.GetDirectories();
                foreach (var directory in directories)
                {
                    string destination = Path.Combine(destinationDirectory.FullName, directory.Name);
                    CopyDirectory(directory, new DirectoryInfo(destination));

                }
                MessageBox.Show("Directory copied succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a path for the New File");

                if (!File.Exists(txtNewFile.Text))
                {
                    File.Create(txtNewFile.Text);
                    MessageBox.Show("File Created");

                }
                else
                {
                    MessageBox.Show("Please enter the full path of the new file");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                //Con la siguiente linea de codigo haremos que se abra el explorador de windows
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSelectedFile.Text = openFileDialog1.FileName;
                    txtRenameFile.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                var source = txtSelectedFile.Text;
                var destination = txtRenameFile.Text;

                var sourceFileInfo = new FileInfo(source);
                if (sourceFileInfo.Exists)
                {
                    sourceFileInfo.MoveTo(destination);
                    MessageBox.Show("The file has been renamed");
                }
                else
                {
                    MessageBox.Show("Error while trying to rename the file. Is the path correct?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}