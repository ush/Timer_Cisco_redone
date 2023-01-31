using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

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
        int previndex = -1;
        bool mute = false;

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
            int tmp_seconds  = 0;
            
            if (userSeconds.Text != "")
            {
                tmp_seconds = Int32.Parse(userSeconds.Text.ToString());
            } else {
                tmp_seconds = 0;
            }

            int tmp_minutes = Int32.Parse(userTime.Text.ToString());

            tmp_minutes += tmp_seconds / 60;
            tmp_seconds = tmp_seconds % 60;

            if (userSeconds.Text == "")
            {
                if (tmp_minutes < 10) {
                    string[] row = { userName.Text, "0" + userTime.Text + ":00" };
                    Table.Rows.Add(row);
                }
                else {
                    string[] row = { userName.Text, userTime.Text + ":00" };
                    Table.Rows.Add(row);
                }
            }
            else
            {
                if (tmp_seconds < 10)
                {
                    if (tmp_minutes < 10)
                    {
                        string[] row = { userName.Text, "0" + tmp_minutes.ToString() + ":" + "0" + tmp_seconds.ToString() };
                        Table.Rows.Add(row);
                    }
                    else
                    {
                        string[] row = { userName.Text, tmp_minutes.ToString() + ":" + "0" + tmp_seconds.ToString() };
                        Table.Rows.Add(row);
                    }
                }
                else
                {
                    if (tmp_minutes < 10)
                    {
                        string[] row = { userName.Text, "0" + tmp_minutes.ToString() + ":" + tmp_seconds.ToString() };
                        Table.Rows.Add(row);
                    }
                    else
                    {
                        string[] row = { userName.Text, tmp_minutes.ToString() + ":" + tmp_seconds.ToString() };
                        Table.Rows.Add(row);
                    }
                }
            }
            //speakersInfo.Add(userName.Text + " время: " + userTime.Text);
            userName.Text = "";
            userTime.Text = "";
            userSeconds.Text = "";
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (previndex != -1)
            {
                this.Table.Rows[previndex].Cells[2].Value = minutes + ":" + seconds;
            }

            previndex = this.Table.CurrentRow.Index;
            
            try
            {
                string temp_name = this.Table.CurrentRow.Cells[0].Value.ToString();
                var temp_parsedTime = this.Table.CurrentRow.Cells[1].Value.ToString().Split(':');
                ticks = Int32.Parse(temp_parsedTime[0]) * 60 + Int32.Parse(temp_parsedTime[1]);
            }
            catch (NullReferenceException)
            {
                return;
            }

            if (buttonContinue.Enabled == false && buttonStop.Enabled == false && addTime.Enabled == false)
            {
                buttonContinue.Enabled = true;
                buttonStop.Enabled = true;
                addTime.Enabled = true;
                logoShower.Enabled = true;
                presentationMode.Enabled = true;
                soundMuter.Enabled = true;
                backgroundColorChooser.Enabled = true;
                textColorChooser.Enabled = true;
                textShower.Enabled = true;
            }

            //parsing table contents
            currentSpeaker.Text = this.Table.CurrentRow.Cells[0].Value.ToString();

            var parsedTime = this.Table.CurrentRow.Cells[1].Value.ToString().Split(':');
            ticks = Int32.Parse(parsedTime[0]) * 60 + Int32.Parse(parsedTime[1]);
            
            presentation.ticks = ticks;
            displayer.ticks = ticks;

            //changing colors
            presentation.presentationTime.BackColor = SystemColors.Control;
            presentation.BackColor = SystemColors.Control;
            presentation.presentationTime.ForeColor = SystemColors.ControlText;

            displayer.displayerTime.BackColor = SystemColors.Control;
            displayer.BackColor = SystemColors.Control;
            displayer.displayerTime.ForeColor = SystemColors.ControlText;

            presentation.presentationName.BackColor = SystemColors.Control;
            presentation.presentationName.ForeColor = SystemColors.ControlText;

            displayer.displayerName.BackColor = SystemColors.Control;
            displayer.displayerName.ForeColor = SystemColors.ControlText;

            //setting Names on forms
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

            if ((sec == 30 || sec == 20 || sec == 10 || sec <= 5) && min == 0 && ticks > 0 && !mute)
            {
                soundPlayer.Play();
            } 
            else
            {
                soundPlayer.Stop();
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
            int min = Math.Abs(ticks / 60);
            int sec = Math.Abs(ticks % 60);

            displayer.Timer.Start();
            presentation.Timer.Start();

            if ((sec == 30 || sec == 20 || sec == 10 || sec <= 5) && min == 0 && ticks > 0 && !mute)
            {
                soundPlayer.Play();
            }
            
            Timer.Start();
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            int additional;

            try
            {
                Int32.Parse(additionalTime.Text.ToString());
            }
            catch (FormatException)
            {
                additionalTime.Text = "";
                additionalSeconds.Text = "";
                return;
            }

            this.BackColor = SystemColors.Control;
            currentTime.ForeColor = SystemColors.ControlText;

            //changing colors
            presentation.presentationTime.ForeColor = SystemColors.ControlText;
            presentation.presentationTime.BackColor = SystemColors.Control;

            displayer.displayerTime.ForeColor = SystemColors.ControlText;
            displayer.displayerTime.BackColor = SystemColors.Control;

            presentation.presentationName.ForeColor = SystemColors.ControlText;
            presentation.presentationName.BackColor = SystemColors.Control;

            displayer.displayerName.ForeColor = SystemColors.ControlText;
            displayer.displayerName.BackColor = SystemColors.Control;

            if (additionalSeconds.Text == "")
            {
                additional = Int32.Parse(additionalTime.Text.ToString()) * 60 + 0;
            }
            else
            {
                additional = Int32.Parse(additionalTime.Text.ToString()) * 60 + Int32.Parse(additionalSeconds.Text.ToString());
            }              
            ticks += additional;
            presentation.ticks += additional;
            displayer.ticks += additional;

            additionalTime.Text = "";
            additionalSeconds.Text = "";
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

        private void soundMuter_CheckedChanged(object sender, EventArgs e)
        {
            if (soundMuter.Checked)
            {
                soundMuter.Text = "Включить";
                soundMuter.BackColor = Color.Green;
                mute = true;
            }
            else
            {
                soundMuter.Text = "Выключить";
                soundMuter.BackColor = Color.Red;
                mute = false;
            }
        }

        private void fileChoser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.Title = "Select file";

            fdlg.InitialDirectory = @"c:\";

            fdlg.FileName = txtFileName.Text;

            fdlg.Filter = "Text and CSV Files(*.txt, *.csv)|*.txt;*.csv|Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";

            fdlg.FilterIndex = 1;

            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)

            {

                txtFileName.Text = fdlg.FileName;

                InsertData(txtFileName.Text);

                Application.DoEvents();

            }
        }

        public void InsertData(string strFileName)
        {
            using (StreamReader sr = new StreamReader(strFileName))
            {
                string[] headers = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    string[] row = sr.ReadLine().Split(',');
                    Table.Rows.Add(row);
                }

            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (Table.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Список.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Невозможно записать сюда: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = Table.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[Table.Rows.Count];
                            for (int i = 0; i < columnCount - 2; i++)
                            {
                                columnNames += Table.Columns[i].HeaderText.ToString();
                                if (i != columnCount - 3)
                                {
                                    columnNames += ",";
                                }
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < Table.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount - 2; j++)
                                {
                                    outputCsv[i] += Table.Rows[i - 1].Cells[j].Value.ToString();
                                    if (j != columnCount - 3)
                                    {
                                        outputCsv[i] += ",";
                                    }
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCsv);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Нечего сохранять", "Info");
            }
        }

        private void textShower_CheckedChanged(object sender, EventArgs e)
        {
            if (textShower.Checked)
            {
                displayer.displayerName.Visible = false;
                displayer.displayerTime.Visible = false;
                presentation.presentationName.Visible = false;
                presentation.presentationTime.Visible = false;
                displayer.textDisplayer.Visible = true;
                presentation.textPresentation.Visible = true;

                displayer.textDisplayer.Text = textInput.Text;
                presentation.textPresentation.Text = textInput.Text;

                textShower.Text = "Скрыть";
                textShower.BackColor = Color.Red;
            }
            else
            {
                displayer.displayerName.Visible = true;
                displayer.displayerTime.Visible = true;
                presentation.presentationName.Visible = true;
                presentation.presentationTime.Visible = true;

                presentation.presentationTime.BackColor = SystemColors.Control;
                presentation.presentationName.BackColor = SystemColors.Control;

                displayer.textDisplayer.Visible = false;
                presentation.textPresentation.Visible = false;

                textShower.Text = "Показать";
                textShower.BackColor = Color.Green;
            }
        }

        private void textColorChooser_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                displayer.textDisplayer.ForeColor = colorDlg.Color;
                presentation.textPresentation.ForeColor = colorDlg.Color;
            }
        }

        private void backgroundColorChooser_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                displayer.textDisplayer.BackColor = colorDlg.Color;
                presentation.textPresentation.BackColor = colorDlg.Color;
                presentation.presentationTime.BackColor = colorDlg.Color;
                presentation.presentationName.BackColor = colorDlg.Color;
            }
        }
    }
}
