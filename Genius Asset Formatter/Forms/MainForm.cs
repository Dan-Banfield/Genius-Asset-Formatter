using TrID;
using System;
using System.IO;
using DarkUI.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Genius_Asset_Formatter
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            AppDomain.CurrentDomain.UnhandledException += (o, e) => MessageBox.Show("An error has occured! The application will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.FormClosing += (o, e) => Process.GetCurrentProcess().Kill();

            InitializeComponent();
        }

        #region Event Handlers

        private void selectAssetsButton_Click(object sender, EventArgs e) => ShowFileSelectionDialogue();

        #endregion

        #region Methods

        private void ShowFileSelectionDialogue()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Title = "Select The Extracted Assets To Convert";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ConvertFiles(ofd.FileNames);
                }
            }
        }

        private async void ConvertFiles(string[] inputFiles)
        {
            PreConversion();

            string outputDirectory = AskForOutputDirectory();
            CreateOutputDirectory(outputDirectory);

            for (int i = 0; i < inputFiles.Length; i++)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFiles[i]);
                string outputFilePath = $@"{outputDirectory}\" + fileNameWithoutExtension + GetFileExtension(inputFiles[i]).ToLower();

                statusLabel.Text = "Status: converting file: " + fileNameWithoutExtension;

                await Task.Run(() => 
                {
                    CopyFile(outputFilePath, inputFiles[i]);
                });
            }

            FinishConversion(outputDirectory);
        }

        private void PreConversion()
        {
            SetControlsToConversionState();
        }

        private void SetControlsToConversionState()
        {
            #region Code Block

            instructionsLabel.Text = "Converting files...";
            selectAssetsButton.Enabled = false;

            #endregion
        }

        private void ResetControlsState()
        {
            #region Code Block

            instructionsLabel.Text = "Please select the extracted assets to convert.";
            selectAssetsButton.Enabled = true;
            statusLabel.Text = "Status: Waiting...";

            #endregion
        }

        private string AskForOutputDirectory()
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select An Output Directory";

                if (fbd.ShowDialog() == DialogResult.OK) return fbd.SelectedPath;
                return "Output";
            }
        }

        private void CreateOutputDirectory(string directory)
        {
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
        }

        private string GetFileExtension(string filePath)
        {
            string result = string.Empty;

            try { result = TrIDEngine.GetExtensionByFileContent(filePath); }
            catch { }

            if (!string.IsNullOrEmpty(result)) return result;
            return ".json";
        }

        private void CopyFile(string outputFilePath, string inputFilePath)
        {
            if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
            File.Copy(inputFilePath, outputFilePath);
        }

        private void FinishConversion(string outputDirectory)
        {
            GC.Collect();

            ResetControlsState();
            MessageBox.Show("The assets were converted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start(outputDirectory);
        }

        #endregion
    }
}
