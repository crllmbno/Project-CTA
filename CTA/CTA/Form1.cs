using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace CTA
{
    public partial class CTA : Form
    {
        public CTA()
        {
            InitializeComponent();
        }

        VideoCaptureDevice cam;
        FilterInfoCollection camera;

        private void CTA_Load(object sender, EventArgs e)
        {
            capture.Hide();
            camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter submit = File.AppendText(Application.StartupPath + "\\Files\\" + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text + ".txt");
            submit.WriteLine("Name: " + tb1.Text + ", " + tb2.Text + " " + tb3.Text + ".");
            submit.WriteLine("Age: " + tb4.Text);
            if (MaleButton.Checked == true)
            {
                submit.WriteLine("Sex: " + MaleButton.Text);
            }
            else if (FemaleButton.Checked == true)
            {
                submit.WriteLine("Sex: " + FemaleButton.Text);
            }
            submit.WriteLine("Address: " + tb5.Text + ", " + tb6.Text + ", " + tb7.Text);
            submit.WriteLine("Cellphone#: " + tb8.Text);
            submit.WriteLine("Telephone#: " + tb9.Text);
            submit.WriteLine("Email: " + tb10.Text);
            submit.WriteLine("Date Recorded: " + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text);
            submit.WriteLine("");
            submit.WriteLine("");
            submit.WriteLine("");
            LB.Items.Add("Name: " + tb1.Text + ", " + tb2.Text + " " + tb3.Text + ".");
            if (MaleButton.Checked == true)
            {
                LB.Items.Add("Sex: " + MaleButton.Text);
            }
            else if (FemaleButton.Checked == true)
            {
                LB.Items.Add("Sex: " + FemaleButton.Text);
            }
            LB.Items.Add("Address: " + tb5.Text + ", " + tb6.Text + ", " + tb7.Text);
            LB.Items.Add("Cellphone#: " + tb8.Text);
            LB.Items.Add("Telephone#: " + tb9.Text);
            LB.Items.Add("Email: " + tb10.Text);
            LB.Items.Add("Date Recorded: " + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text);
            LB.Items.Add(" ");
            LB.Items.Add(" ");
            LB.Items.Add(" ");

            submit.Close();
            MessageBox.Show("Form Submitted");
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            tb6.Clear();
            tb7.Clear();
            tb8.Text = "09";
            tb9.Clear();
            tb10.Text = "@gmail.com";
            MonthBox.Text = "Month";
            DayBox.Text = "Day";
            YearBox.Text = "Year";
            MaleButton.Checked = false;
            FemaleButton.Checked = false;
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            capture.Show();
            cam = new VideoCaptureDevice(camera[0].MonikerString);
            cam.NewFrame += new AForge.Video.NewFrameEventHandler(Camera_NewFrame);
            cam.Start();
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs e)
        {
            capture.Image = (Bitmap)e.Frame.Clone();
        }

        private void CTA_FormClosed(object sender, FormClosedEventArgs e)
        {
            //blank
        }

        private void CTA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning)
                cam.Stop();
        }

        private void t1_Tick(object sender, EventArgs e)
        {

        }
    }
}
