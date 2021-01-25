using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace Timer_Cisco_redone
{
    public partial class Controller : Form
    {
        public SoundPlayer soundPlayer;
        List<string> speakersInfo = new List<string>();

        Displayer displayer = new Displayer();
        Presentation presentation = new Presentation();

        int ticks;
        string minutes = "";
        string seconds = "";

        public Controller()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
            soundPlayer.Stream = Properties.Resources.Wecker_sound;
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            displayer.Show();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                userName.Text.ToString();
                Int32.Parse(userTime.Text.ToString());
            }
            catch (FormatException)
            {
                userTime.Text = "";
                userName.Text = "";
                return;
            }
            speakersInfo.Add(userName.Text + " время: " + userTime.Text);
            string[] row = { userName.Text, userTime.Text };
            Table.Rows.Add(row);
            userName.Text = "";
            userTime.Text = "";
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string temp_name = this.Table.CurrentRow.Cells[0].Value.ToString();
                int temp_time = Int32.Parse(this.Table.CurrentRow.Cells[1].Value.ToString()) * 60;
            }
            catch (NullReferenceException)
            {
                return;
            }

            displayer.Show();

            displayer.tmhLogo.Visible = false;
            presentation.tmhLogo.Visible = false;

            if (displayer.displayerName.Visible == false && displayer.displayerTime.Visible == false)
            {
                displayer.displayerName.Visible = true;
                displayer.displayerTime.Visible = true;
                displayer.tmhLogo.Visible = false;
            }

            if (buttonContinue.Enabled == false && buttonStop.Enabled == false && addTime.Enabled == false)
            {
                buttonContinue.Enabled = true;
                buttonStop.Enabled = true;
                addTime.Enabled = true;
                logoShower.Enabled = true;
                presentationMode.Enabled = true;
            }

            currentSpeaker.Text = this.Table.CurrentRow.Cells[0].Value.ToString();
            ticks = Int32.Parse(this.Table.CurrentRow.Cells[1].Value.ToString()) * 60;
            presentation.ticks = Int32.Parse(this.Table.CurrentRow.Cells[1].Value.ToString()) * 60;
            displayer.ticks = Int32.Parse(this.Table.CurrentRow.Cells[1].Value.ToString()) * 60;

            presentation.presentationTime.BackColor = SystemColors.Control;
            presentation.BackColor = SystemColors.Control;
            presentation.presentationTime.ForeColor = SystemColors.ControlText;

            displayer.displayerTime.BackColor = SystemColors.Control;
            displayer.BackColor = SystemColors.Control;
            displayer.displayerTime.ForeColor = SystemColors.ControlText;

            displayer.displayerName.Text = this.Table.CurrentRow.Cells[0].Value.ToString();
            presentation.presentationName.Text = this.Table.CurrentRow.Cells[0].Value.ToString();

            displayer.Timer.Start();
            presentation.Timer.Start();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int min = Math.Abs(ticks / 60);
            int sec = Math.Abs(ticks % 60);

            if (sec > 5)
            {
                soundPlayer.Stop();
            }

            if (ticks < 0)
            {
                soundPlayer.Stop();
                minutes = (Math.Abs(ticks / 60)).ToString();
                seconds = (Math.Abs(ticks % 60)).ToString();
                if (minutes.Length == 1)
                {
                    minutes = "-0" + minutes;
                }
                if (seconds.Length == 1)
                {
                    seconds = "0" + seconds;
                }
            }
            else
            {
                minutes = (ticks / 60).ToString();
                seconds = (ticks % 60).ToString();
                if (minutes.Length == 1)
                {
                    minutes = "0" + minutes;
                }
                if (seconds.Length == 1)
                {
                    seconds = "0" + seconds;
                }
            }
            currentTime.Text = minutes + ":" + seconds;

            if ((sec == 30 || sec == 20 || sec == 10 || sec <= 5) && min == 0 && ticks > 0)
            {
                soundPlayer.Play();
            }
            ticks--;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            displayer.Timer.Stop();
            presentation.Timer.Stop();
            soundPlayer.Stop();
            Timer.Stop();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            displayer.Timer.Start();
            presentation.Timer.Start();
            soundPlayer.Play();
            Timer.Start();
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(additionalTime.Text.ToString());
            }
            catch (FormatException)
            {
                additionalTime.Text = "";
                return;
            }

            this.BackColor = SystemColors.Control;
            currentTime.ForeColor = SystemColors.ControlText;

            presentation.BackColor = SystemColors.Control;
            presentation.presentationTime.ForeColor = SystemColors.ControlText;
            presentation.presentationTime.BackColor = SystemColors.Control;

            displayer.BackColor = SystemColors.Control;
            displayer.displayerTime.ForeColor = SystemColors.ControlText;
            displayer.displayerTime.BackColor = SystemColors.Control;

            ticks += Int32.Parse(additionalTime.Text.ToString()) * 60;
            presentation.ticks += Int32.Parse(additionalTime.Text.ToString()) * 60;
            displayer.ticks += Int32.Parse(additionalTime.Text.ToString()) * 60;
            additionalTime.Text = "";
        }

        private void logoShower_CheckedChanged(object sender, EventArgs e)
        {
            if (logoShower.Checked)
            {
                logoShower.Text = "Скрыть";
                logoShower.BackColor = Color.Red;
                displayer.tmhLogo.Visible = true;
                presentation.tmhLogo.Visible = true;
            }
            else
            {
                logoShower.Text = "Показать";
                logoShower.BackColor = Color.Green;
                displayer.tmhLogo.Visible = false;
                presentation.tmhLogo.Visible = false;
            }
        }

        private void presentationMode_CheckedChanged(object sender, EventArgs e)
        {
            if (presentationMode.Checked)
            {
                presentationMode.Text = "Выключить";
                presentationMode.BackColor = Color.Red;
                presentation.Show();
                displayer.Hide();
            }
            else
            {
                presentationMode.Text = "Включить";
                presentationMode.BackColor = Color.Green;
                presentation.Hide();
                displayer.Show();
            }
        }

        private void Polzunok_Scroll(object sender, EventArgs e)
        {
            presentation.Opacity = ((double)Polzunok.Value / 100.0);
            opacityValue.Text = "Видимость: " + Polzunok.Value.ToString() + "%";
        }
    }
}
