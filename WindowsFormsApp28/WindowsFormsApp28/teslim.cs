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
    public partial class teslim : Form
    {

        public void showDataOgr()
        {

            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=cs;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM studentınfo", dt);
            DataTable d = new DataTable();
            my.Fill(d);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in d.Rows)
            {
                int r = dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = item["Name"].ToString();
                dataGridView1.Rows[r].Cells[1].Value = item["Class"].ToString();
                dataGridView1.Rows[r].Cells[2].Value = item["Number"].ToString();
                dataGridView1.Rows[r].Cells[3].Value = item["ParentName"].ToString();
                dataGridView1.Rows[r].Cells[4].Value = item["Contact"].ToString();
            }
        }
        public void showDataTeslim()
        {

            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=teslim;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM teslimm", dt);
            DataTable d = new DataTable();
            my.Fill(d);
            dataGridView3.Rows.Clear();
            foreach (DataRow item in d.Rows)
            {
                int r = dataGridView3.Rows.Add();
                dataGridView3.Rows[r].Cells[0].Value = item["ogrN"].ToString();
                dataGridView3.Rows[r].Cells[1].Value = item["ktpN"].ToString();
                dataGridView3.Rows[r].Cells[2].Value = item["take"].ToString();
                dataGridView3.Rows[r].Cells[3].Value = item["dead"].ToString();
                
            }
        }

        public void showDataKitap()
        {

            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=csk;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM kitapcs", dt);
            DataTable d = new DataTable();
            my.Fill(d);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in d.Rows)
            {
                int r = dataGridView2.Rows.Add();
                dataGridView2.Rows[r].Cells[0].Value = item["Numara"].ToString();
                dataGridView2.Rows[r].Cells[1].Value = item["Kitapİsmi"].ToString();
                dataGridView2.Rows[r].Cells[2].Value = item["Yazarı"].ToString();
                dataGridView2.Rows[r].Cells[3].Value = item["Türü"].ToString();
                dataGridView2.Rows[r].Cells[4].Value = item["Konum"].ToString();
            }
        }

        public teslim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection dt2 = new MySqlConnection("Server= 127.0.0.1;Database=cs;" + "User ID= root;PASSWORD=qweasdzxc123");
            dt2.Open();
            var com2 = "SELECT Name FROM studentınfo Where Number='"+textBox1.Text+"' ";

            MySqlCommand command2 = dt2.CreateCommand();
            command2.CommandText = com2;
            command2.ExecuteNonQuery();
            string x = com2;

            dt2.Close();
            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=teslim;" + "User ID= root;PASSWORD=qweasdzxc123");
            dt.Open();

            

            var com  = "INSERT INTO teslimm (ogrN,ktpN,take,dead) VALUES ('"+x+"','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "'    )";
           

            MySqlCommand command = dt.CreateCommand();
            command.CommandText = com;
            command.ExecuteNonQuery();

            dt.Close();
            textBox1.Clear();
            textBox2.Clear();
            label8.Visible = true;
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void teslim_Load(object sender, EventArgs e)
        {
            label4.Text = ("Bugün\n" + dateTimePicker1.Value);
            showDataOgr();
            showDataKitap();
            showDataTeslim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            dateTimePicker2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            checkBox1.Checked = false;
            label6.Visible = false;
            label7.Visible = false;
            checkBox1.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
            dataGridView3.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showDataTeslim();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            checkBox1.Checked = false;
            label6.Visible = true;
            label7.Visible = false;
            checkBox1.Visible = true;
            textBox3.Visible = true;
            button5.Visible = true;
            dataGridView3.Visible = true; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=teslim;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            //MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM studentınfo", dt);


            //DELETE FROM Customers WHERE CustomerName = 'Alfreds Futterkiste';
            var com = "DELETE FROM teslimm WHERE ogrN  = ('" + textBox3.Text + "')";



            MySqlCommand command = dt.CreateCommand();
            command.CommandText = com;
            command.ExecuteNonQuery();

            dt.Close();
            showDataTeslim();
            textBox3.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = ("Bugün\n" + dateTimePicker1.Value);
        }
    }
}

//if (dateTimePicker1.Value < dateTimePicker2.Value ) 
//{
//    MessageBox.Show("date 1 date 2 den daha güncel");
//}
//else if (dateTimePicker1.Value < dateTimePicker2.Value)
//{
//    MessageBox.Show("date 2 date 1 den daha güncel");
//}
//else if (dateTimePicker1.Value == dateTimePicker2.Value)
//{
//    MessageBox.Show("aynı");
//}

/* MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=csk;" + "User ID= root;PASSWORD=qweasdzxc123");

 dt.Open();

 var com = ""; //select cart curt

 com = "INSERT INTO kitapcs (Numara,Kitapİsmi,Yazarı,Türü,Konum) VALUES('" + textBox4.Text + "'," +
     "'" + txtVeriGirisi.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";


 MySqlCommand command = dt.CreateCommand();
 command.CommandText = com;
 command.ExecuteNonQuery();

 dt.Close();*/




//showData();



//if (dateTimePicker1.Value > dateTimePicker2.Value)
//{
//    MessageBox.Show("date 1 date 2 den daha güncel");
//}
//else if (dateTimePicker1.Value < dateTimePicker2.Value)
//{
//    MessageBox.Show("date 2 date 1 den daha güncel");
//}
//else if (dateTimePicker1.Value == dateTimePicker2.Value)
//{
//    MessageBox.Show("aynı");
//}