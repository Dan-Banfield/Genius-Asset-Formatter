
namespace Genius_Asset_Formatter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.instructionsLabel = new DarkUI.Controls.DarkLabel();
            this.selectAssetsButton = new DarkUI.Controls.DarkButton();
            this.statusLabel = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 13);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(383, 25);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Please select the extracted assets to convert.";
            // 
            // selectAssetsButton
            // 
            this.selectAssetsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAssetsButton.Location = new System.Drawing.Point(17, 51);
            this.selectAssetsButton.Name = "selectAssetsButton";
            this.selectAssetsButton.Padding = new System.Windows.Forms.Padding(5);
            this.selectAssetsButton.Size = new System.Drawing.Size(551, 64);
            this.selectAssetsButton.TabIndex = 2;
            this.selectAssetsButton.Text = "Select";
            this.selectAssetsButton.Click += new System.EventHandler(this.selectAssetsButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.statusLabel.Location = new System.Drawing.Point(12, 124);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(566, 30);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status: Waiting...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 162);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.selectAssetsButton);
            this.Controls.Add(this.instructionsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius Asset Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel instructionsLabel;
        private DarkUI.Controls.DarkButton selectAssetsButton;
        private DarkUI.Controls.DarkLabel statusLabel;
    }
}

