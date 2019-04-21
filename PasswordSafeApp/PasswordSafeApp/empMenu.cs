using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSafeApp
{
    public partial class empMenu : Form
    {
        public empMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage();
            this.Hide();
            l1.Show();
        }
    }
}
