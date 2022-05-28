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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string textBox1 = this.textBox1.Text;//非空验证
            if (textBox1 == "")
            {
                MessageBox.Show("密码不能为空！！！！", "提示：", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (textBox1 == "12")
                {
                    MessageBox.Show("密码正确请登录","提示：", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("登录失败,请返回重试！！！","提示：",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
