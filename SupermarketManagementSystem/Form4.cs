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
        //创建ds数据集对象
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            //获取输入的名字关键字
            string key = textBox1.Text;
            //创建 DataView对象
            DataView dv = ds.Tables[0].DefaultView;
            //按名字模糊查询过滤数据源
            dv.RowFilter = string.Format("name like '%{0}%'", key);
            //设置DataGriView的数据源
            this.dataGridView1.DataSource = dv;
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
            //创建链接字符串
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            //创建链接对象
            SqlConnection conn = new SqlConnection(connString);
            //查询数据库sol语句
            string sql = "select * from Jinh";
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


            // TODO: 这行代码将数据加载到表“sqwDataSet6.Jinh”中。您可以根据需要移动或移除它。
            this.jinhTableAdapter1.Fill(this.sqwDataSet6.Jinh);
            // TODO: 这行代码将数据加载到表“sqwDataSet3.Jinh”中。您可以根据需要移动或移除它。
            this.jinhTableAdapter.Fill(this.sqwDataSet3.Jinh);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;database=sqw;uid=sa;pwd=123456";
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
                string sql = $"insert Jinh values({ID},'{name}','{shul}','{jinj}','{jiner}','{shouj}','{zhek}','{riqi}','{baiz}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("添加成功","提示",MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("添加失败","提示");
                }
                conn.Close();
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
