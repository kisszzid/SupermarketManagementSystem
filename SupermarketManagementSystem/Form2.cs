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

            /*string textBox1 = this.textBox1.Text;//非空验证
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
        }*/
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
            string connstr = "server=.;database=sqw;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            
            if (comboBox1.Text!="")
            {
                if (comboBox2.Text!="")
                {
                    if (textBox1.Text!="")
                    {
                        string id = comboBox2.Text;
                        string pass = textBox1.Text;
                        string sql = string.Format("select * from Denglu where name='{0}' and mima='{1}'", id, pass);
                        SqlDataReader reader = DBHelper.GetDataReader(sql);
                        if (reader.HasRows)
                        {
                            DBHelper.Conn.Close();
                            DialogResult result = MessageBox.Show("登录成功！","提示：", MessageBoxButtons.OKCancel);
                            if (result==DialogResult.OK)
                            {
                                Form3 form3 = new Form3();
                                form3.Show();
                                Close();
                            }
                            else
                            {
                                Close();
                            }
                           
                        }
                        else
                        {
                            DBHelper.Conn.Close();
                            MessageBox.Show("登陆失败！", "提示：", MessageBoxButtons.OKCancel);
                        }

                    }
                    else
                    {
                        MessageBox.Show("请输入密码!", "提示：", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {
                    MessageBox.Show("请选择用户！", "提示：", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("请选择班次！", "提示：", MessageBoxButtons.OKCancel);
            }

            
            }
        }
    }
