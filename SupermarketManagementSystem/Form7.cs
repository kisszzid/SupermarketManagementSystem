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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //创建ds数据集对象
        DataSet ds = new DataSet();
        private void button8_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //创建链接字符串
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            //创建链接对象
            SqlConnection conn = new SqlConnection(connString);
            //查询数据库sol语句
            string sql = "select * from Yuangong";
            //定义DataAdapter对象
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            //填充数据
            dap.Fill(ds);
            //取消dataGridView1生成列
            dataGridView1.AutoGenerateColumns = false;
            //设置dataGridView1的数据源
            dataGridView1.DataSource = ds.Tables[0];
            //关闭并释放连接对象
            conn.Close();
            conn.Dispose();


            // TODO: 这行代码将数据加载到表“sqwDataSet9.Yuangong”中。您可以根据需要移动或移除它。
            // this.yuangongTableAdapter1.Fill(this.sqwDataSet9.Yuangong);
            // TODO: 这行代码将数据加载到表“sqwDataSet8.Yuangong”中。您可以根据需要移动或移除它。
            //this.yuangongTableAdapter.Fill(this.sqwDataSet8.Yuangong);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;database=sqw;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" )
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                string dianh = textBox3.Text;
                string dixin = textBox4.Text;
                string tichen = textBox5.Text;
                string beiz = textBox6.Text;
                string sql = $"insert Yuangong values({ID},'{name}','{dianh}','{dixin}','{tichen}','{beiz}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OKCancel);
                    string sql2 = "select * from Yuangong";
                    //定义DataAdapter对象
                    SqlDataAdapter dap = new SqlDataAdapter(sql2, conn);
                    //填充数据
                    DataTable dat = new DataTable();
                    dap.Fill(dat);
                    //设置dataGridView1的数据源
                    dataGridView1.DataSource = dat;
                    conn.Close();
                    conn.Dispose();
                }
                else
                {
                    MessageBox.Show("添加失败", "提示", MessageBoxButtons.OKCancel);
                }
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string name = textBox2.Text;
            string sql = string.Format("delete from Yuangong where name = '{0}'",name );
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("删除成功","提示", MessageBoxButtons.OKCancel);
                string sql2 = "select * from Yuangong";
                //定义DataAdapter对象
                SqlDataAdapter dap = new SqlDataAdapter(sql2, conn);
                //填充数据
                DataTable dat = new DataTable();
                dap.Fill(dat);
                //设置dataGridView1的数据源
                dataGridView1.DataSource = dat;
                conn.Close();
                conn.Dispose();
            }
            else
            {
                MessageBox.Show("删除失败","提示", MessageBoxButtons.OKCancel);
                conn.Close();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string dianh = textBox3.Text;
            string dixin = textBox4.Text;
            string tichen = textBox5.Text;
            string ruzhi = dataGridView1.Text;
            string beiz = textBox6.Text;
            string sql = string.Format("update Yuangong set dianh='{0}',dixin='{1}',tichen='{2}',ruzhi='{3}',beiz='{4}' where name='{5}'",dianh, dixin, tichen, ruzhi, beiz,name);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("修改成功","提示", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("修改失败","提示", MessageBoxButtons.OKCancel);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
