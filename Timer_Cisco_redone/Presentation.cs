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
    public partial class Presentation : Form
    {
        public int ticks = 0;
        string minutes = "";
        string seconds = "";

        public Presentation()
        {
            this.TopMost = true;
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ticks < 0)
            {
                minutes = Math.Abs(ticks / 60).ToString();
                seconds = Math.Abs(ticks % 60).ToString();
                if (ticks % 2 == 0)
                {
                    presentationTime.ForeColor = Color.Black;
                }
                if (ticks % 2 != 0)
                {
                    presentationTime.ForeColor = Color.Red;
                }

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

            presentationTime.Text = minutes + ":" + seconds;
            ticks--;
        }

        private void Presentation_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        Point lastPoint;
        private void Presentation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Presentation_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
