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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqwDataSet9.Yuangong”中。您可以根据需要移动或移除它。
            this.yuangongTableAdapter1.Fill(this.sqwDataSet9.Yuangong);
            // TODO: 这行代码将数据加载到表“sqwDataSet8.Yuangong”中。您可以根据需要移动或移除它。
            this.yuangongTableAdapter.Fill(this.sqwDataSet8.Yuangong);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
