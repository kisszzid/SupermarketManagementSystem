using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            员工管理 form7 = new 员工管理();
            form7.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqwDataSet1.Diy”中。您可以根据需要移动或移除它。
            this.diyTableAdapter.Fill(this.sqwDataSet1.Diy);
            // TODO: 这行代码将数据加载到表“sqwDataSet.Huiyuang”中。您可以根据需要移动或移除它。
            this.huiyuangTableAdapter.Fill(this.sqwDataSet.Huiyuang);
            this.timer1.Start();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 Form6 = new Form7();
            Form6.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            Hide();
        }
    }
}
