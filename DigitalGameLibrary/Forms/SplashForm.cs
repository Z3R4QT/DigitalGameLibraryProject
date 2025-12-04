using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Tag = "fadeIn";

            ProgressBar1.Value = 0;
            timer1.Interval = 50;
            timer1.Start();



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Tag.ToString() == "fadeIn")
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    timer1.Stop();
                    timer1.Start();

                    ProgressBar1.Increment(1);

                    if (ProgressBar1.Value >= ProgressBar1.Maximum)
                    {
                        timer1.Stop();

                        this.Hide();
                        new LoginForm().Show();


                    }
                }
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
