using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_home_work_WPF
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        private void Timer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToLongTimeString();
            TimeText.Text = time;
        }
        private void London_Tick(object sender,EventArgs e)
        {
            TimeText.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }
        private void Azerri_Time_Zone_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Baku;
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void England_Time_Zone_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.London;
            timer.Tick += London_Tick;
            timer.Interval = 1000;
            timer.Start();
        }
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }
    }

}
