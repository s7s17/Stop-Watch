using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            stopwatch.Stop();
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            stopwatch.Start();
            btn_record.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = (stopwatch.ElapsedMilliseconds / 1000.0).ToString("f2");
            if((stopwatch.ElapsedMilliseconds % 100) == 0)
                lb_caption.ForeColor = (Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))); 
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer1.Enabled = false;
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            lv_records.Items.Add(lb_time.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lv_records.Items.Clear();
            stopwatch.Reset();
            lb_time.Text = "0.0";
            timer1.Stop();
            timer1.Enabled = false;
            btn_record.Enabled = false;
        }
    }
}
