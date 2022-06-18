namespace SupermarketManagementSystem
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("苹果");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("黑美人西瓜");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("菠萝");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("草莓");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("水果类", new System.Windows.Forms.TreeNode[] {
            treeNode169,
            treeNode170,
            treeNode171,
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("牙刷");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("潘婷护发素               ");
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("生活用品", new System.Windows.Forms.TreeNode[] {
            treeNode174,
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("饼干");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("纯牛奶");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("泡奶饼干");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("零食类", new System.Windows.Forms.TreeNode[] {
            treeNode177,
            treeNode178,
            treeNode179});
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.sqwDataSet2 = new SupermarketManagementSystem.sqwDataSet2();
            this.shangpingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shangpingTableAdapter = new SupermarketManagementSystem.sqwDataSet2TableAdapters.ShangpingTableAdapter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqwDataSet7 = new SupermarketManagementSystem.sqwDataSet7();
            this.shangpingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shangpingTableAdapter1 = new SupermarketManagementSystem.sqwDataSet7TableAdapters.ShangpingTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuanjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoujDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiaojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiaosyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shangpingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shangpingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号/名称：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(823, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "只显示库存大于0";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(856, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "商品销售";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(856, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "进货管理";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(856, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "库存管理";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(856, 373);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 42);
            this.button6.TabIndex = 9;
            this.button6.Text = "会员管理";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(856, 466);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 42);
            this.button7.TabIndex = 10;
            this.button7.Text = "每日明细";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // sqwDataSet2
            // 
            this.sqwDataSet2.DataSetName = "sqwDataSet2";
            this.sqwDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shangpingBindingSource
            // 
            this.shangpingBindingSource.DataMember = "Shangping";
            this.shangpingBindingSource.DataSource = this.sqwDataSet2;
            // 
            // shangpingTableAdapter
            // 
            this.shangpingTableAdapter.ClearBeforeFill = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 86);
            this.treeView1.Name = "treeView1";
            treeNode169.Name = "节点1";
            treeNode169.Text = "苹果";
            treeNode170.Name = "节点3";
            treeNode170.Text = "黑美人西瓜";
            treeNode171.Name = "节点4";
            treeNode171.Text = "菠萝";
            treeNode172.Name = "节点5";
            treeNode172.Text = "草莓";
            treeNode173.Checked = true;
            treeNode173.Name = "节点0";
            treeNode173.Text = "水果类";
            treeNode174.Name = "节点10";
            treeNode174.Text = "牙刷";
            treeNode175.Name = "节点11";
            treeNode175.Text = "潘婷护发素               ";
            treeNode176.Name = "节点9";
            treeNode176.Text = "生活用品";
            treeNode177.Name = "节点17";
            treeNode177.Text = "饼干";
            treeNode178.Name = "节点18";
            treeNode178.Text = "纯牛奶";
            treeNode179.Name = "节点19";
            treeNode179.Text = "泡奶饼干";
            treeNode180.Name = "节点16";
            treeNode180.Text = "零食类";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode173,
            treeNode176,
            treeNode180});
            this.treeView1.Size = new System.Drawing.Size(137, 455);
            this.treeView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "按售价升序排序";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(618, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(199, 48);
            this.button8.TabIndex = 13;
            this.button8.Text = "按数量降序排序";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shulDataGridViewTextBoxColumn,
            this.yuanjDataGridViewTextBoxColumn,
            this.zhekDataGridViewTextBoxColumn,
            this.shoujDataGridViewTextBoxColumn,
            this.xiaojDataGridViewTextBoxColumn,
            this.xiaosyDataGridViewTextBoxColumn,
            this.biezDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shangpingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(147, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(688, 455);
            this.dataGridView1.TabIndex = 14;
            // 
            // sqwDataSet7
            // 
            this.sqwDataSet7.DataSetName = "sqwDataSet7";
            this.sqwDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shangpingBindingSource1
            // 
            this.shangpingBindingSource1.DataMember = "Shangping";
            this.shangpingBindingSource1.DataSource = this.sqwDataSet7;
            // 
            // shangpingTableAdapter1
            // 
            this.shangpingTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // shulDataGridViewTextBoxColumn
            // 
            this.shulDataGridViewTextBoxColumn.DataPropertyName = "shul";
            this.shulDataGridViewTextBoxColumn.HeaderText = "数量";
            this.shulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shulDataGridViewTextBoxColumn.Name = "shulDataGridViewTextBoxColumn";
            this.shulDataGridViewTextBoxColumn.Width = 125;
            // 
            // yuanjDataGridViewTextBoxColumn
            // 
            this.yuanjDataGridViewTextBoxColumn.DataPropertyName = "yuanj";
            this.yuanjDataGridViewTextBoxColumn.HeaderText = "原价";
            this.yuanjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yuanjDataGridViewTextBoxColumn.Name = "yuanjDataGridViewTextBoxColumn";
            this.yuanjDataGridViewTextBoxColumn.Width = 125;
            // 
            // zhekDataGridViewTextBoxColumn
            // 
            this.zhekDataGridViewTextBoxColumn.DataPropertyName = "zhek";
            this.zhekDataGridViewTextBoxColumn.HeaderText = "折扣";
            this.zhekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zhekDataGridViewTextBoxColumn.Name = "zhekDataGridViewTextBoxColumn";
            this.zhekDataGridViewTextBoxColumn.Width = 125;
            // 
            // shoujDataGridViewTextBoxColumn
            // 
            this.shoujDataGridViewTextBoxColumn.DataPropertyName = "shouj";
            this.shoujDataGridViewTextBoxColumn.HeaderText = "售价";
            this.shoujDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shoujDataGridViewTextBoxColumn.Name = "shoujDataGridViewTextBoxColumn";
            this.shoujDataGridViewTextBoxColumn.Width = 125;
            // 
            // xiaojDataGridViewTextBoxColumn
            // 
            this.xiaojDataGridViewTextBoxColumn.DataPropertyName = "xiaoj";
            this.xiaojDataGridViewTextBoxColumn.HeaderText = "小计";
            this.xiaojDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xiaojDataGridViewTextBoxColumn.Name = "xiaojDataGridViewTextBoxColumn";
            this.xiaojDataGridViewTextBoxColumn.Width = 125;
            // 
            // xiaosyDataGridViewTextBoxColumn
            // 
            this.xiaosyDataGridViewTextBoxColumn.DataPropertyName = "xiaosy";
            this.xiaosyDataGridViewTextBoxColumn.HeaderText = "销售员";
            this.xiaosyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xiaosyDataGridViewTextBoxColumn.Name = "xiaosyDataGridViewTextBoxColumn";
            this.xiaosyDataGridViewTextBoxColumn.Width = 125;
            // 
            // biezDataGridViewTextBoxColumn
            // 
            this.biezDataGridViewTextBoxColumn.DataPropertyName = "biez";
            this.biezDataGridViewTextBoxColumn.HeaderText = "备注";
            this.biezDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biezDataGridViewTextBoxColumn.Name = "biezDataGridViewTextBoxColumn";
            this.biezDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form5";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shangpingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shangpingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private sqwDataSet2 sqwDataSet2;
        private System.Windows.Forms.BindingSource shangpingBindingSource;
        private sqwDataSet2TableAdapters.ShangpingTableAdapter shangpingTableAdapter;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sqwDataSet7 sqwDataSet7;
        private System.Windows.Forms.BindingSource shangpingBindingSource1;
        private sqwDataSet7TableAdapters.ShangpingTableAdapter shangpingTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yuanjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoujDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiaojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiaosyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biezDataGridViewTextBoxColumn;
    }
}