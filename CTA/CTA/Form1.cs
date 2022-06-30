using AForge.Video;
using AForge.Video.DirectShow;


namespace CTA
{
    public partial class CTA : Form
    {
        public CTA()
        {
            InitializeComponent();
        }

        VideoCaptureDevice cam;
        FilterInfoCollection Devices;

        private void CTA_Load(object sender, EventArgs e)
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in Devices)
                camera.Items.Add(filterInfo.Name);
            camera.SelectedIndex = 0;
            capture.Hide();
            lbl1.Hide();
            camera.Hide();
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter submit = File.AppendText(Application.StartupPath + "\\New List\\" + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text + ".txt");
            submit.WriteLine("Name: " + box1.Text + ", " + box2.Text + " " + box3.Text + ".");
            submit.WriteLine("Age: " + box4.Text);
            if (MaleButton.Checked == true)
            {
                submit.WriteLine("Sex: " + MaleButton.Text);
            }
            else if (FemaleButton.Checked == true)
            {
                submit.WriteLine("Sex: " + FemaleButton.Text);
            }
            submit.WriteLine("Address: " + box5.Text + ", " + box6.Text + ", " + box7.Text);
            submit.WriteLine("Cellphone#: " + box8.Text);
            submit.WriteLine("Telephone#: " + box9.Text);
            submit.WriteLine("Email: " + box10.Text);
            submit.WriteLine("Date Recorded: " + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text);
            submit.WriteLine("");
            submit.WriteLine("");
            submit.WriteLine("");
            LB.Items.Add("Name: " + box1.Text + ", " + box2.Text + " " + box3.Text + ".");
            if (MaleButton.Checked == true)
            {
                LB.Items.Add("Sex: " + MaleButton.Text);
            }
            else if (FemaleButton.Checked == true)
            {
                LB.Items.Add("Sex: " + FemaleButton.Text);
            }
            LB.Items.Add("Address: " + box5.Text + ", " + box6.Text + ", " + box7.Text);
            LB.Items.Add("Cellphone#: " + box8.Text);
            LB.Items.Add("Telephone#: " + box9.Text);
            LB.Items.Add("Email: " + box10.Text);
            LB.Items.Add("Date Recorded: " + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text);
            LB.Items.Add(" ");
            LB.Items.Add(" ");
            LB.Items.Add(" ");

            submit.Close();
            MessageBox.Show("Form Submitted");
            box1.Clear();
            box2.Clear();
            box3.Clear();
            box4.Clear();
            box5.Clear();
            box6.Clear();
            box7.Clear();
            box8.Text = "09";
            box9.Clear();
            box10.Text = "@gmail.com";
            MonthBox.Text = "Month";
            DayBox.Text = "Day";
            YearBox.Text = "Year";
            MaleButton.Checked = false;
            FemaleButton.Checked = false;

            

        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            ListForm List = new ListForm();
            List.Show();
            this.Hide();
        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt12_Click(object sender, EventArgs e)
        {

        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Scan_Click(object sender, EventArgs e)
        {
            capture.Show();
            lbl1.Show();
            camera.Show(); 
            cam = new VideoCaptureDevice(Devices[camera.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();

        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            capture.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CTA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cam.IsRunning)
                cam.Stop();
        }       
    }
}