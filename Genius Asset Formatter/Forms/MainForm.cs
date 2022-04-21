using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using TrID;
using System.Diagnostics;

namespace Genius_Asset_Formatter
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            AppDomain.CurrentDomain.UnhandledException += (o, e) => MessageBox.Show("An error has occured! Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.FormClosing += (o, e) => Process.GetCurrentProcess().Kill();

            InitializeComponent();
        }

        #region Event Handlers

        private void selectAssetsButton_Click(object sender, EventArgs e) => ShowFileSelectionDialogue();

        #endregion

        #region Methods

        private string GetFileExtension(string filePath)
        {
            return TrIDEngine.GetExtensionByFileContent(filePath);
        }

        private void ResetControlsState()
        {
            instructionsLabel.Text = "Please select the extracted assets to convert.";
            selectAssetsButton.Enabled = true;
            statusLabel.Text = "Status: Waiting...";
        }

        private void SetControlsConversionState()
        {
            instructionsLabel.Text = "Converting files...";
            selectAssetsButton.Enabled = false;
        }

        private void FinishConversion()
        {
            ResetControlsState();

            MessageBox.Show("The assets were converted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start(Directory.GetCurrentDirectory() + @"\Output");
        }

        private void PrepareForConversion()
        {
            SetControlsConversionState();

            if (!Directory.Exists("Output")) Directory.CreateDirectory("Output");
        }

        private async void ConvertFiles(string[] inputFiles)
        {
            PrepareForConversion();

            string fileNameWithoutExtension = string.Empty;
            string outputFilePath = string.Empty;

            for (ushort i = 0; i < inputFiles.Length; i++)
            {
                fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFiles[i]);
                outputFilePath = @"Output\" + fileNameWithoutExtension + GetFileExtension(inputFiles[i]);

                statusLabel.Text = "Status: converting file: " + fileNameWithoutExtension;

                await Task.Run(() => 
                {
                    if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
                    File.Copy(inputFiles[i], outputFilePath);
                });
            }

            FinishConversion();
        }

        private void ShowFileSelectionDialogue()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Title = "Select the extracted assets to convert.";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ConvertFiles(ofd.FileNames);
                }
            }
        }

        #endregion
    }
}
