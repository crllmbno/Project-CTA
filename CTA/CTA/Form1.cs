namespace CTA
{
    public partial class CTA : Form
    {
        public CTA()
        {
            InitializeComponent();
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

        private void CTA_Load(object sender, EventArgs e)
        {

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
    }
}