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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //创建ds数据集对象
        DataSet ds = new DataSet();
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqwDataSet7.Shangping”中。您可以根据需要移动或移除它。
            this.shangpingTableAdapter1.Fill(this.sqwDataSet7.Shangping);
            //创建链接字符串
            string connString = "server=.;database=sqw;uid =sa;pwd =123456";
            //创建链接对象
            SqlConnection conn = new SqlConnection(connString);
            //查询数据库sol语句
            string sql = "select * from Shangping";
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


            // TODO: 这行代码将数据加载到表“sqwDataSet2.Shangping”中。您可以根据需要移动或移除它。
           // this.shangpingTableAdapter.Fill(this.sqwDataSet2.Shangping);

        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            //按库存数量降序排序
            dv.Sort = "shul DESC";
            dataGridView1.DataSource = dv;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            //按金额升序排序
            dv.Sort = "shouj ASC";
            dataGridView1.DataSource = dv;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
