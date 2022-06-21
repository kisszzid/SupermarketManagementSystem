using System;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class Form3 : Form
    {
        public double xfzj = 0;//消费总额
        public int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqwDataSet1.Diy”中。您可以根据需要移动或移除它。
            this.diyTableAdapter.Fill(this.sqwDataSet1.Diy);
            // TODO: 这行代码将数据加载到表“sqwDataSet.Huiyuang”中。您可以根据需要移动或移除它。
            this.huiyuangTableAdapter.Fill(this.sqwDataSet.Huiyuang);
            this.timer1.Start();


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            string foodid = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            i++;
            xfzj += Convert.ToDouble(textBox4.Text.Trim());//赋值给到textBox控件
            textBox2.Text = xfzj.ToString();
            textBox6.Text += textBox3.Text.Trim() + "*1" ;
     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//显示商品名称
            textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();//显示商品售价
            textBox5.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//显示商品折扣
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
