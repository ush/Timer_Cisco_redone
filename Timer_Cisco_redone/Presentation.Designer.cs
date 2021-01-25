
namespace Timer_Cisco_redone
{
    partial class Presentation
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
            this.components = new System.ComponentModel.Container();
            this.presentationName = new System.Windows.Forms.Label();
            this.presentationTime = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tmhLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tmhLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // presentationName
            // 
            this.presentationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presentationName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.presentationName.Location = new System.Drawing.Point(12, 31);
            this.presentationName.Name = "presentationName";
            this.presentationName.Size = new System.Drawing.Size(423, 49);
            this.presentationName.TabIndex = 0;
            this.presentationName.Text = "Сейчас выступает";
            this.presentationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presentationTime
            // 
            this.presentationTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presentationTime.Font = new System.Drawing.Font("Segoe UI", 72F);
            this.presentationTime.Location = new System.Drawing.Point(1, 80);
            this.presentationTime.Name = "presentationTime";
            this.presentationTime.Size = new System.Drawing.Size(448, 158);
            this.presentationTime.TabIndex = 1;
            this.presentationTime.Text = "00:00";
            this.presentationTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tmhLogo
            // 
            this.tmhLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tmhLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tmhLogo.Image = global::Timer_Cisco_redone.Properties.Resources.tmh_logo_mini;
            this.tmhLogo.Location = new System.Drawing.Point(-4, -16);
            this.tmhLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tmhLogo.Name = "tmhLogo";
            this.tmhLogo.Size = new System.Drawing.Size(453, 303);
            this.tmhLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tmhLogo.TabIndex = 2;
            this.tmhLogo.TabStop = false;
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 264);
            this.Controls.Add(this.tmhLogo);
            this.Controls.Add(this.presentationTime);
            this.Controls.Add(this.presentationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Presentation";
            this.Opacity = 0.25D;
            this.Text = "Presentation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Presentation_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Presentation_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Presentation_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.tmhLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.PictureBox tmhLogo;
        public System.Windows.Forms.Label presentationName;
        public System.Windows.Forms.Label presentationTime;
    }
}