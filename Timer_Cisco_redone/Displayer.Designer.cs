
namespace Timer_Cisco_redone
{
    partial class Displayer
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
            this.displayerName = new System.Windows.Forms.Label();
            this.displayerTime = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tmhLogo = new System.Windows.Forms.PictureBox();
            this.textDisplayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tmhLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // displayerName
            // 
            this.displayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayerName.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.displayerName.Location = new System.Drawing.Point(4, 41);
            this.displayerName.Name = "displayerName";
            this.displayerName.Size = new System.Drawing.Size(1245, 133);
            this.displayerName.TabIndex = 0;
            this.displayerName.Text = "Сейчас выступает";
            this.displayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayerTime
            // 
            this.displayerTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayerTime.Font = new System.Drawing.Font("Segoe UI", 199.8F);
            this.displayerTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayerTime.Location = new System.Drawing.Point(6, 174);
            this.displayerTime.Name = "displayerTime";
            this.displayerTime.Size = new System.Drawing.Size(1251, 447);
            this.displayerTime.TabIndex = 1;
            this.displayerTime.Text = "00:00";
            this.displayerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tmhLogo
            // 
            this.tmhLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tmhLogo.ErrorImage = null;
            this.tmhLogo.Image = global::Timer_Cisco_redone.Properties.Resources.tmh_logo;
            this.tmhLogo.InitialImage = null;
            this.tmhLogo.Location = new System.Drawing.Point(-225, -124);
            this.tmhLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tmhLogo.Name = "tmhLogo";
            this.tmhLogo.Size = new System.Drawing.Size(1623, 976);
            this.tmhLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tmhLogo.TabIndex = 2;
            this.tmhLogo.TabStop = false;
            this.tmhLogo.Visible = false;
            // 
            // textDisplayer
            // 
            this.textDisplayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDisplayer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDisplayer.Location = new System.Drawing.Point(-1, 0);
            this.textDisplayer.Name = "textDisplayer";
            this.textDisplayer.Size = new System.Drawing.Size(1258, 718);
            this.textDisplayer.TabIndex = 3;
            this.textDisplayer.Text = "Сейчас выступает";
            this.textDisplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textDisplayer.Visible = false;
            // 
            // Displayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 718);
            this.Controls.Add(this.tmhLogo);
            this.Controls.Add(this.displayerTime);
            this.Controls.Add(this.displayerName);
            this.Controls.Add(this.textDisplayer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Displayer";
            this.Text = "Displayer";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Displayer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tmhLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label displayerName;
        public System.Windows.Forms.Label displayerTime;
        public System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.PictureBox tmhLogo;
        public System.Windows.Forms.Label textDisplayer;
    }
}