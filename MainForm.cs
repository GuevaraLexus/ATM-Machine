using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATMMachine_Group3
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnStartTransaction_Click_1(object sender, EventArgs e)
        {
            frmLoginForm login = new frmLoginForm();
            login.Show();
            this.Hide();
        }
    }
}
