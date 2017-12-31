namespace Presentation.Admin
{
    partial class Admin_Logo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Logo));
            this.picWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // picWelcome
            // 
            this.picWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWelcome.BackgroundImage")));
            this.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWelcome.Location = new System.Drawing.Point(157, 79);
            this.picWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(811, 399);
            this.picWelcome.TabIndex = 5;
            this.picWelcome.TabStop = false;
            // 
            // Admin_Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1360, 733);
            this.Controls.Add(this.picWelcome);
            this.Name = "Admin_Logo";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWelcome;
    }
}