using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketManagementSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;datase=sqw;uid=sa;pwd=1234";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            if (textBox2.Text != "" && textBox3.Text!="" && textBox4.Text!="" && textBox5.Text!="" && textBox6.Text!="" && textBox7.Text!="" && textBox8.Text!="" && textBox9.Text!="")
            {
                int ID = int.Parse(textBox2.Text);
                string name = textBox3.Text;
                string shul = textBox4.Text;
                string jinj = textBox5.Text;
                string jiner = textBox6.Text;
                string shouj = textBox7.Text;
                string zhek = textBox8.Text;
                string riqi = dateTimePicker2.Text;
                string baiz = textBox9.Text;
                string sql = "insert huhu values({ID},'{name}','{shul}','{jinj}','{jiner}','{shouj}','{zhek}','{riqi}','{baiz}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                conn.Close();
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
