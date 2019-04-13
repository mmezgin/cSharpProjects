using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp28
{
    public partial class Log__Screen : Form
    {
        public Log__Screen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form1 ana = new Form1();
           
            string k_adi = textBox1.Text, sifre = textBox2.Text;
            if (k_adi=="admin" && sifre=="mert")
            {
                MessageBox.Show("Giriş Başarılı !");
                ana.Show();
                this.Hide();
            }
            else
            {
                
                label3.Visible = true;

                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
