using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTA
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            StreamReader search = new StreamReader(Application.StartupPath + "\\New List\\" + MonthBox.Text + " " + DayBox.Text + ", " + YearBox.Text + ".txt");
            SearchWindow.Text = search.ReadToEnd();

            search.Close();
        }

        private void ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
