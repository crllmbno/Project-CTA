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
            StreamWriter submit = File.AppendText(@"List.txt");
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
            submit.WriteLine("");
            submit.WriteLine("");
            submit.WriteLine("");
            submit.Close();
            MessageBox.Show("Form Submitted");
            box1.Clear();
            box2.Clear();
            box3.Clear();
            box4.Clear();
            box5.Clear();
            box6.Clear();
            box7.Clear();
            box8.Clear();
            box9.Clear();
            box10.Clear();
            MaleButton.Checked = false;
            FemaleButton.Checked = false;

        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            ListForm List = new ListForm();
            List.Show();
            this.Hide();
        }
    }
}