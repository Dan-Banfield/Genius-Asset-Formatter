using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    tutorialLabel.Text = "This is the third tutorial step.";
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
