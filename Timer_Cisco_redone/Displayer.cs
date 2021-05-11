using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Cisco_redone
{
    public partial class Displayer : Form
    {
        public int ticks = 0;
        string minutes = "";
        string seconds = "";

        public Displayer()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ticks < 0)
            {
                minutes = Math.Abs(ticks / 60).ToString();
                seconds = Math.Abs(ticks % 60).ToString();
                displayerTime.ForeColor = Color.Red;

                if (minutes.Length == 1)
                {
                    minutes = "-0" + minutes;
                }
                else
                {
                    minutes = "-" + minutes;
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

            displayerTime.Text = minutes + ":" + seconds;
            ticks--;
        }

        private void Displayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
