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
            submit.WriteLine("Name: " + box1.Text + ", " + box2.Text + " " + box3.Text);

            submit.Close();
            box1.Clear();
            box2.Clear();
            box3.Clear();

        }
    }
}