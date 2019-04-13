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
    

    public partial class Ogr : Form
    {
        

        public Ogr()
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=cs;"+"User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();

            var com = ""; //select cart curt
            
            com = "INSERT INTO studentınfo (Name,Class,Number,ParentName,Contact) VALUES('"+txtVeriGirisi.Text+"'," +
                "'"+textBox1.Text+"','" +textBox2.Text+"','" + textBox3.Text+"','"  +textBox4.Text+ "')";


            MySqlCommand command = dt.CreateCommand();
            command.CommandText = com;
            command.ExecuteNonQuery();

            dt.Close();



            CleanTekbaks();
            showData();
        }

        private void CleanTekbaks()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox  )
                {
                    TextBox t = c as TextBox;
                    t.Clear();
                  
                
                }
              
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("yanlış butona bastınız!");
            }
        }
        private void Ogr_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void txtVeriGirisi_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }       
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }
        public void showData()
        {

            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=cs;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM studentınfo", dt);
            DataTable d = new DataTable();
            my.Fill(d);
            dataGridView1.Rows.Clear();
            foreach ( DataRow item in d.Rows)
            {
                int r = dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = item["Name"].ToString();
                dataGridView1.Rows[r].Cells[1].Value = item["Class"].ToString();
                dataGridView1.Rows[r].Cells[2].Value = item["Number"].ToString();
                dataGridView1.Rows[r].Cells[3].Value = item["ParentName"].ToString();
                dataGridView1.Rows[r].Cells[4].Value = item["Contact"].ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=cs;" + "User ID= root;PASSWORD=qweasdzxc123");

            dt.Open();
            //MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM studentınfo", dt);
            

            //DELETE FROM Customers WHERE CustomerName = 'Alfreds Futterkiste';
            var com = "DELETE FROM studentınfo WHERE Number  = ('" + textBox5.Text + "')";
            


            MySqlCommand command = dt.CreateCommand();
            command.CommandText = com;
            command.ExecuteNonQuery();

            dt.Close();
            textBox5.Clear();
            showData();
            //com = "INSERT INTO studentınfo (Name,Class,Number,ParentName,Contact) VALUES('" + txtVeriGirisi.Text + "'," +
            //   "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            İletişim.Visible = true;
            txtVeriGirisi.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            btnAdd.Visible = true;
            checkBox1.Checked = false;
            label5.Visible = false;
            label6.Visible = false;
            
            textBox5.Visible = false;
            button2.Visible = false;
            checkBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            label5.Visible = true;
           
            
            textBox5.Visible = true;
            button2.Visible = true;
            checkBox1.Checked = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            İletişim.Visible = false;
            txtVeriGirisi.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            btnAdd.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
        }
    }
    
}
//ListViewItem item = new ListViewItem();

//if (e.KeyValue == 13)
//{


//    if (!string.IsNullOrEmpty(txtVeriGirisi.Text) && sayac == 0)
//    {
//        item.Text = txtVeriGirisi.Text;
//        sayac++;
//    }
//    else if (true)
//    {

//    }

//    c = c + 1;

//    if (e.KeyValue == 13 && c == 1)
//    {
//        x = textBox1.Text;
//        item.Text = x;
//        textBox1.Clear();



//    }
//    if (e.KeyValue == 13 && c == 2)
//    {
//        y = textBox1.Text;
//        item.SubItems.Add(y);
//        textBox1.Clear();
//    }
//    if (e.KeyValue == 13 && c == 3)
//    {
//        z = textBox1.Text;
//        item.SubItems.Add(z);
//        textBox1.Clear();
//    }
//    if (e.KeyValue == 13 && c == 4)
//    {
//        a = textBox1.Text;
//        item.SubItems.Add(a);
//        textBox1.Clear();
//    }
//    if (e.KeyValue == 13 && c == 5)
//    {
//        b = textBox1.Text;
//        item.SubItems.Add(b);
//        textBox1.Clear();
//        c++;

//    }
//    if (c == 6)
//    {
//        MessageBox.Show("Uyarı !");

//    }

//}





//listView1.Items.Add(item);

// if(c is MaskedTextBox)
//{
//    MaskedTextBox r = c as MaskedTextBox;
//    r.Clear();
//}