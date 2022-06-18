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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //创建ds数据集对象
        DataSet ds = new DataSet();
        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //获取输入的名字关键字
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            //创建链接对象
            SqlConnection conn = new SqlConnection(connString);
            //查询数据库sol语句
            string sql = "select * from Huiyuang";
            //定义DataAdapter对象
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            //填充数据
            dap.Fill(ds);
            string key = textBox1.Text;
            //创建 DataView对象
            DataView dv = ds.Tables[0].DefaultView;
            //按名字模糊查询过滤数据源
            dv.RowFilter = string.Format("name like '%{0}%'", key);
            //设置DataGriView的数据源
            this.dataGridView1.DataSource = dv;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqwDataSet12.Huiyuang”中。您可以根据需要移动或移除它。
            this.huiyuangTableAdapter3.Fill(this.sqwDataSet12.Huiyuang);
            // TODO: 这行代码将数据加载到表“sqwDataSet11.Huiyuang”中。您可以根据需要移动或移除它。
            this.huiyuangTableAdapter2.Fill(this.sqwDataSet11.Huiyuang);
            // TODO: 这行代码将数据加载到表“sqwDataSet10.Huiyuang”中。您可以根据需要移动或移除它。
            this.huiyuangTableAdapter1.Fill(this.sqwDataSet10.Huiyuang);
            //创建链接字符串
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            //创建链接对象
            SqlConnection conn = new SqlConnection(connString);
            //查询数据库sol语句
            string sql = "select * from Huiyuang";
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


            // TODO: 这行代码将数据加载到表“sqwDataSet4.Huiyuang”中。您可以根据需要移动或移除它。
            this.huiyuangTableAdapter.Fill(this.sqwDataSet4.Huiyuang);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
            Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;database=sqw;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" )
            {
                int ID = int.Parse(textBox2.Text);
                string name = textBox3.Text;
                string jibei = textBox5.Text;
                string zhek = textBox6.Text;
                string jifen = textBox4.Text;
                string xfei = textBox7.Text;
                string shengri = dateTimePicker1.Text;
                string lifa = textBox8.Text;
                string shuoji = textBox9.Text;
                string banka = textBox10.Text;
                string biez = textBox11.Text;
                string sql = $"insert Huiyuang values({ID},'{name}','{jibei}','{zhek}','{jifen}','{xfei}','{shengri}','{lifa}','{shuoji}','{banka}','{biez}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OKCancel);
                    string sql2 = "select * from Huiyuang";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox2.Text);
            string name = textBox3.Text;
            string jibei = textBox5.Text;
            string zhek = textBox6.Text;
            string jifen = textBox4.Text;
            string xfei = textBox7.Text;
            string shengri = dateTimePicker1.Text;
            string lifa = textBox8.Text;
            string shuoji = textBox9.Text;
            string banka = textBox10.Text;
            string biez = textBox11.Text;
            string oldname = textBox12.Text;
            string sql = string.Format("update Huiyuang set ID = '{0}',name='{1}',jibei='{2}',zhek='{3}',jifen='{4}',xfei='{5}',shengri='{6}',lifa='{7}',shuoji='{8}',banka='{9}',biez='{10}'  where name='{11}'", ID, name, jibei, zhek, jifen, xfei, shengri, lifa, shuoji, banka, biez, oldname);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("修改成功","提示");

                string connString = "server=.;database=sqw;uid =sa;pwd =123456";
                SqlConnection conn = new SqlConnection(connString);
                string sql2 = "select * from Huiyuang";
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
                MessageBox.Show("修改失败", "提示");
            }
            

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            SqlConnection conn = new SqlConnection(connString);
            string name = textBox3.Text;
            string sql = string.Format("delete from Huiyuang where name = '{0}'", name);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OKCancel);
                //查询数据库sol语句
                string sql2 = "select * from Huiyuang";
                //定义DataAdapter对象
                SqlDataAdapter dap = new SqlDataAdapter(sql2, conn);
                //填充数据
                DataTable dat = new DataTable();
                dap.Fill(dat);
                //设置dataGridView1的数据源
               dataGridView1.DataSource = dat;
            }
            else
            {
                MessageBox.Show("删除失败", "提示", MessageBoxButtons.OKCancel);
            }

            conn.Close();
            conn.Dispose();

        }
    }
}
