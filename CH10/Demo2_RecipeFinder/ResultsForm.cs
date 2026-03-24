using System;
using System.Windows.Forms;

namespace Demo2_RecipeFinder
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(string results)
        {
            InitializeComponent();
            rtbResults.Text = results;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
