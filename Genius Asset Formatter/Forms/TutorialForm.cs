using System;
using DarkUI.Forms;

namespace Genius_Asset_Formatter
{
    public partial class TutorialForm : DarkForm
    {
        #region Properties

        private byte currentTutorialStep = 0;

        #endregion

        public TutorialForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e) => NextTutorialStep();

        private void NextTutorialStep()
        {
            currentTutorialStep += 1;
            ActivateTutorialEvent(currentTutorialStep);
        }

        private void ActivateTutorialEvent(byte tutorialEventNumber)
        {
            switch (tutorialEventNumber)
            {
                case 1:
                    tutorialLabel.Text = "Firstly, download any Studio Genius Japan Inc game of your choice, and play up until around chapter three (or skip through until that point).";
                    break;
                case 2:
                    tutorialLabel.Text = "Next, open your device's file manager. If it doesn't have one, you can download a free one from the Google Play store.";
                    break;
                case 3:
                    tutorialLabel.Text = "Then, navigate to the following path: Android -> data -> studio.genius.yourgamename.";
                    tutorialImageBox.Image = Properties.Resources.Tutorial_Image_1;
                    break;
                case 4:
                    tutorialLabel.Text = "Next, go from there to: files -> data -> studio.genius.yourgamename, and you should find a load of random blank files.";
                    tutorialImageBox.Image = Properties.Resources.Tutorial_Image_2;
                    break;
                case 5:
                    tutorialLabel.Text = "That's where this app comes in! With it, you can convert these files into their correct formats.";
                    tutorialImageBox.Image = null;
                    break;
                case 6:
                    tutorialLabel.Text = "Well, that's all there is to it! Thanks for using this application.";
                    nextButton.Text = "Done";
                    break;
                default:
                    FinishTutorial();
                    break;
            }
        }

        private void FinishTutorial()
        {
            new MainForm().Show();
            this.Hide();
        }
    }
}
