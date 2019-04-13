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
    public partial class ktp : Form
    {
        public void showData()
        {

            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=csk;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM kitapcs", dt);
            DataTable d = new DataTable();
            my.Fill(d);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in d.Rows)
            {
                int r = dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = item["Numara"].ToString();
                dataGridView1.Rows[r].Cells[1].Value = item["Kitapİsmi"].ToString();
                dataGridView1.Rows[r].Cells[2].Value = item["Yazarı"].ToString();
                dataGridView1.Rows[r].Cells[3].Value = item["Türü"].ToString();
                dataGridView1.Rows[r].Cells[4].Value = item["Konum"].ToString();
            }
        }

        public ktp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void ktp_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=csk;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();

            var com = ""; //select cart curt

            com = "INSERT INTO kitapcs (Numara,Kitapİsmi,Yazarı,Türü,Konum) VALUES('" + textBox4.Text + "'," +
                "'" + txtVeriGirisi.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";


            MySqlCommand command = dt.CreateCommand();
            command.CommandText = com;
            command.ExecuteNonQuery();

            dt.Close();




            showData();

            txtVeriGirisi.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=csk;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            //MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM studentınfo", dt);


            //DELETE FROM Customers WHERE CustomerName = 'Alfreds Futterkiste';
            var com = "DELETE FROM kitapcs WHERE Numara  = ('" + textBox5.Text + "')";



            MySqlCommand command = dt.CreateCommand();
            command.CommandText = com;
            command.ExecuteNonQuery();

            dt.Close();
            showData();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtVeriGirisi.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            btnAdd.Visible = true;
            checkBox1.Checked = false;
            button4.Visible = false;
            label6.Visible = false;
            checkBox1.Visible = false; 
            textBox5.Visible = false;
            
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtVeriGirisi.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            btnAdd.Visible = false;
            checkBox1.Checked = false;
            button4.Visible = true;
            label6.Visible = true;
            checkBox1.Visible = true;
            textBox5.Visible = true;
        }
    }
    

}
