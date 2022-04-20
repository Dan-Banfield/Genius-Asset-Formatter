using System;
using System.Windows.Forms;

namespace Genius_Asset_Formatter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HandleLaunchMode();
        }

        private static void HandleLaunchMode()
        {
            if (Properties.Settings.Default.isFirstLaunch)
            {
                if (MessageBox.Show("Since this is your first launch, would you like to go through a tutorial on how to use this application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Run(new TutorialForm());
                }
                else
                {
                    Application.Run(new MainForm());
                }
                Properties.Settings.Default.isFirstLaunch = false;
                Properties.Settings.Default.Save();
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
