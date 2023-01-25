
namespace Timer_Cisco_redone
{
    partial class Controller
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
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userTime = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentSpeaker = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.currentTime = new System.Windows.Forms.Label();
            this.additionalTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addTime = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.logoShower = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.presentationMode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Polzunok = new System.Windows.Forms.TrackBar();
            this.opacityValue = new System.Windows.Forms.Label();
            this.additionalSeconds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userSeconds = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.soundMuter = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Polzunok)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Location = new System.Drawing.Point(45, 106);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(217, 22);
            this.userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выступающие";
            // 
            // userTime
            // 
            this.userTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTime.Location = new System.Drawing.Point(45, 172);
            this.userTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTime.Name = "userTime";
            this.userTime.Size = new System.Drawing.Size(217, 22);
            this.userTime.TabIndex = 3;
            // 
            // savebutton
            // 
            this.savebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.savebutton.Location = new System.Drawing.Point(45, 266);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(156, 45);
            this.savebutton.TabIndex = 4;
            this.savebutton.Text = "Сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Table
            // 
            this.Table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableName,
            this.tableTime,
            this.tableRemaining,
            this.Show});
            this.Table.Location = new System.Drawing.Point(619, 45);
            this.Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 29;
            this.Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.Size = new System.Drawing.Size(478, 599);
            this.Table.TabIndex = 6;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // tableName
            // 
            this.tableName.HeaderText = "Имя";
            this.tableName.MinimumWidth = 6;
            this.tableName.Name = "tableName";
            // 
            // tableTime
            // 
            this.tableTime.HeaderText = "Время";
            this.tableTime.MinimumWidth = 6;
            this.tableTime.Name = "tableTime";
            // 
            // tableRemaining
            // 
            this.tableRemaining.HeaderText = "Превышение";
            this.tableRemaining.MinimumWidth = 6;
            this.tableRemaining.Name = "tableRemaining";
            // 
            // Show
            // 
            this.Show.HeaderText = "Показать";
            this.Show.MinimumWidth = 6;
            this.Show.Name = "Show";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(45, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время (мин)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(45, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "ФИО";
            // 
            // currentSpeaker
            // 
            this.currentSpeaker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentSpeaker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.currentSpeaker.Location = new System.Drawing.Point(-1, 332);
            this.currentSpeaker.Name = "currentSpeaker";
            this.currentSpeaker.Size = new System.Drawing.Size(333, 29);
            this.currentSpeaker.TabIndex = 9;
            this.currentSpeaker.Text = "Выступающий сейчас";
            this.currentSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // currentTime
            // 
            this.currentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Segoe UI", 52.2F);
            this.currentTime.Location = new System.Drawing.Point(34, 370);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(257, 116);
            this.currentTime.TabIndex = 10;
            this.currentTime.Text = "00:00";
            // 
            // additionalTime
            // 
            this.additionalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalTime.Location = new System.Drawing.Point(45, 520);
            this.additionalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.additionalTime.Name = "additionalTime";
            this.additionalTime.Size = new System.Drawing.Size(186, 22);
            this.additionalTime.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(45, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дополнительное время (мин)";
            // 
            // addTime
            // 
            this.addTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addTime.Enabled = false;
            this.addTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addTime.Location = new System.Drawing.Point(45, 613);
            this.addTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTime.Name = "addTime";
            this.addTime.Size = new System.Drawing.Size(156, 45);
            this.addTime.TabIndex = 13;
            this.addTime.Text = "Добавить";
            this.addTime.UseVisualStyleBackColor = false;
            this.addTime.Click += new System.EventHandler(this.addTime_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStop.Location = new System.Drawing.Point(358, 370);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(156, 45);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonContinue.Enabled = false;
            this.buttonContinue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonContinue.Location = new System.Drawing.Point(358, 428);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(156, 45);
            this.buttonContinue.TabIndex = 15;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // logoShower
            // 
            this.logoShower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoShower.Appearance = System.Windows.Forms.Appearance.Button;
            this.logoShower.BackColor = System.Drawing.Color.Green;
            this.logoShower.Enabled = false;
            this.logoShower.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoShower.Location = new System.Drawing.Point(358, 613);
            this.logoShower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoShower.Name = "logoShower";
            this.logoShower.Size = new System.Drawing.Size(156, 45);
            this.logoShower.TabIndex = 16;
            this.logoShower.Text = "Показать";
            this.logoShower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoShower.UseVisualStyleBackColor = false;
            this.logoShower.CheckedChanged += new System.EventHandler(this.logoShower_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(358, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Заставка";
            // 
            // presentationMode
            // 
            this.presentationMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presentationMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.presentationMode.BackColor = System.Drawing.Color.Green;
            this.presentationMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.presentationMode.Enabled = false;
            this.presentationMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.presentationMode.Location = new System.Drawing.Point(358, 147);
            this.presentationMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.presentationMode.Name = "presentationMode";
            this.presentationMode.Size = new System.Drawing.Size(156, 45);
            this.presentationMode.TabIndex = 18;
            this.presentationMode.Text = "Включить";
            this.presentationMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.presentationMode.UseVisualStyleBackColor = false;
            this.presentationMode.CheckedChanged += new System.EventHandler(this.presentationMode_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(358, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Режим презентации";
            // 
            // Polzunok
            // 
            this.Polzunok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Polzunok.Location = new System.Drawing.Point(358, 247);
            this.Polzunok.Maximum = 100;
            this.Polzunok.Name = "Polzunok";
            this.Polzunok.Size = new System.Drawing.Size(211, 56);
            this.Polzunok.TabIndex = 20;
            this.Polzunok.Value = 65;
            this.Polzunok.Scroll += new System.EventHandler(this.Polzunok_Scroll);
            // 
            // opacityValue
            // 
            this.opacityValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opacityValue.AutoSize = true;
            this.opacityValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opacityValue.Location = new System.Drawing.Point(363, 213);
            this.opacityValue.Name = "opacityValue";
            this.opacityValue.Size = new System.Drawing.Size(158, 28);
            this.opacityValue.TabIndex = 21;
            this.opacityValue.Text = "Видимость: 65%";
            // 
            // additionalSeconds
            // 
            this.additionalSeconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalSeconds.Location = new System.Drawing.Point(45, 576);
            this.additionalSeconds.Name = "additionalSeconds";
            this.additionalSeconds.Size = new System.Drawing.Size(186, 22);
            this.additionalSeconds.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Дополнительное время (сек)";
            // 
            // userSeconds
            // 
            this.userSeconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userSeconds.Location = new System.Drawing.Point(45, 233);
            this.userSeconds.Name = "userSeconds";
            this.userSeconds.Size = new System.Drawing.Size(217, 22);
            this.userSeconds.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Время (сек)";
            // 
            // soundMuter
            // 
            this.soundMuter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soundMuter.Appearance = System.Windows.Forms.Appearance.Button;
            this.soundMuter.BackColor = System.Drawing.Color.Red;
            this.soundMuter.Enabled = false;
            this.soundMuter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.soundMuter.Location = new System.Drawing.Point(358, 520);
            this.soundMuter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soundMuter.Name = "soundMuter";
            this.soundMuter.Size = new System.Drawing.Size(156, 45);
            this.soundMuter.TabIndex = 28;
            this.soundMuter.Text = "Выключить";
            this.soundMuter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soundMuter.UseVisualStyleBackColor = false;
            this.soundMuter.CheckedChanged += new System.EventHandler(this.soundMuter_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(358, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "Звук";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 674);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.soundMuter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userSeconds);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.additionalSeconds);
            this.Controls.Add(this.opacityValue);
            this.Controls.Add(this.Polzunok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.presentationMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logoShower);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.addTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.additionalTime);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.currentSpeaker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.userTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Controller";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.Controller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Polzunok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTime;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentSpeaker;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.TextBox additionalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addTime;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.CheckBox logoShower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox presentationMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar Polzunok;
        private System.Windows.Forms.Label opacityValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableRemaining;
        private System.Windows.Forms.DataGridViewButtonColumn Show;
        private System.Windows.Forms.TextBox additionalSeconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userSeconds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox soundMuter;
        private System.Windows.Forms.Label label9;
    }
}

