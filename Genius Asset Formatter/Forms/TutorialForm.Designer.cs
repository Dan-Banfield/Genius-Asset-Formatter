
namespace Genius_Asset_Formatter
{
    partial class TutorialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialForm));
            this.tutorialLabel = new DarkUI.Controls.DarkLabel();
            this.nextButton = new DarkUI.Controls.DarkButton();
            this.tutorialImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tutorialLabel.Location = new System.Drawing.Point(12, 9);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(702, 127);
            this.tutorialLabel.TabIndex = 0;
            this.tutorialLabel.Text = "Welcome! This tutorial will show you how to use this application, and how to extr" +
    "act assets from Studio Genius Japan Inc games.";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(17, 268);
            this.nextButton.Name = "nextButton";
            this.nextButton.Padding = new System.Windows.Forms.Padding(5);
            this.nextButton.Size = new System.Drawing.Size(697, 64);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // tutorialImageBox
            // 
            this.tutorialImageBox.Location = new System.Drawing.Point(17, 145);
            this.tutorialImageBox.Name = "tutorialImageBox";
            this.tutorialImageBox.Size = new System.Drawing.Size(697, 114);
            this.tutorialImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tutorialImageBox.TabIndex = 2;
            this.tutorialImageBox.TabStop = false;
            // 
            // TutorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 344);
            this.Controls.Add(this.tutorialImageBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.tutorialLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TutorialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius Asset Formatter - Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.tutorialImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkLabel tutorialLabel;
        private DarkUI.Controls.DarkButton nextButton;
        private System.Windows.Forms.PictureBox tutorialImageBox;
    }
}

