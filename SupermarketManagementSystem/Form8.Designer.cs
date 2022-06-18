namespace SupermarketManagementSystem
{
    partial class Form8
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sqwDataSet5 = new SupermarketManagementSystem.sqwDataSet5();
            this.meirixiaolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meirixiaolTableAdapter = new SupermarketManagementSystem.sqwDataSet5TableAdapters.meirixiaolTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jinerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yinglDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zfbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhaolingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhaozyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shijianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meirixiaolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "显示当天",
            "显示一个月内",
            "显示半年内",
            "显示一年内",
            "显示全部"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(234, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 23);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "至";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(425, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 23);
            this.comboBox3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "删除销售单";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "补打小票";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(884, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "打印报表";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shulDataGridViewTextBoxColumn,
            this.jinerDataGridViewTextBoxColumn,
            this.yinglDataGridViewTextBoxColumn,
            this.wxDataGridViewTextBoxColumn,
            this.zfbDataGridViewTextBoxColumn,
            this.zhaolingDataGridViewTextBoxColumn,
            this.zhaozyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bancDataGridViewTextBoxColumn,
            this.shijianDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meirixiaolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(947, 406);
            this.dataGridView1.TabIndex = 14;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(563, 496);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 32);
            this.button12.TabIndex = 33;
            this.button12.Text = "每日明细";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(425, 496);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 32);
            this.button11.TabIndex = 32;
            this.button11.Text = "会员管理";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(287, 496);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 32);
            this.button10.TabIndex = 31;
            this.button10.Text = "库存管理";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(148, 496);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 32);
            this.button9.TabIndex = 30;
            this.button9.Text = "进货采购";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 496);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 32);
            this.button8.TabIndex = 29;
            this.button8.Text = "商品采购";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // sqwDataSet5
            // 
            this.sqwDataSet5.DataSetName = "sqwDataSet5";
            this.sqwDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meirixiaolBindingSource
            // 
            this.meirixiaolBindingSource.DataMember = "meirixiaol";
            this.meirixiaolBindingSource.DataSource = this.sqwDataSet5;
            // 
            // meirixiaolTableAdapter
            // 
            this.meirixiaolTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // shulDataGridViewTextBoxColumn
            // 
            this.shulDataGridViewTextBoxColumn.DataPropertyName = "shul";
            this.shulDataGridViewTextBoxColumn.HeaderText = "shul";
            this.shulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shulDataGridViewTextBoxColumn.Name = "shulDataGridViewTextBoxColumn";
            this.shulDataGridViewTextBoxColumn.Width = 125;
            // 
            // jinerDataGridViewTextBoxColumn
            // 
            this.jinerDataGridViewTextBoxColumn.DataPropertyName = "jiner";
            this.jinerDataGridViewTextBoxColumn.HeaderText = "jiner";
            this.jinerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jinerDataGridViewTextBoxColumn.Name = "jinerDataGridViewTextBoxColumn";
            this.jinerDataGridViewTextBoxColumn.Width = 125;
            // 
            // yinglDataGridViewTextBoxColumn
            // 
            this.yinglDataGridViewTextBoxColumn.DataPropertyName = "yingl";
            this.yinglDataGridViewTextBoxColumn.HeaderText = "yingl";
            this.yinglDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yinglDataGridViewTextBoxColumn.Name = "yinglDataGridViewTextBoxColumn";
            this.yinglDataGridViewTextBoxColumn.Width = 125;
            // 
            // wxDataGridViewTextBoxColumn
            // 
            this.wxDataGridViewTextBoxColumn.DataPropertyName = "wx";
            this.wxDataGridViewTextBoxColumn.HeaderText = "wx";
            this.wxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wxDataGridViewTextBoxColumn.Name = "wxDataGridViewTextBoxColumn";
            this.wxDataGridViewTextBoxColumn.Width = 125;
            // 
            // zfbDataGridViewTextBoxColumn
            // 
            this.zfbDataGridViewTextBoxColumn.DataPropertyName = "zfb";
            this.zfbDataGridViewTextBoxColumn.HeaderText = "zfb";
            this.zfbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zfbDataGridViewTextBoxColumn.Name = "zfbDataGridViewTextBoxColumn";
            this.zfbDataGridViewTextBoxColumn.Width = 125;
            // 
            // zhaolingDataGridViewTextBoxColumn
            // 
            this.zhaolingDataGridViewTextBoxColumn.DataPropertyName = "zhaoling";
            this.zhaolingDataGridViewTextBoxColumn.HeaderText = "zhaoling";
            this.zhaolingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zhaolingDataGridViewTextBoxColumn.Name = "zhaolingDataGridViewTextBoxColumn";
            this.zhaolingDataGridViewTextBoxColumn.Width = 125;
            // 
            // zhaozyDataGridViewTextBoxColumn
            // 
            this.zhaozyDataGridViewTextBoxColumn.DataPropertyName = "zhaozy";
            this.zhaozyDataGridViewTextBoxColumn.HeaderText = "zhaozy";
            this.zhaozyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zhaozyDataGridViewTextBoxColumn.Name = "zhaozyDataGridViewTextBoxColumn";
            this.zhaozyDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bancDataGridViewTextBoxColumn
            // 
            this.bancDataGridViewTextBoxColumn.DataPropertyName = "banc";
            this.bancDataGridViewTextBoxColumn.HeaderText = "banc";
            this.bancDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bancDataGridViewTextBoxColumn.Name = "bancDataGridViewTextBoxColumn";
            this.bancDataGridViewTextBoxColumn.Width = 125;
            // 
            // shijianDataGridViewTextBoxColumn
            // 
            this.shijianDataGridViewTextBoxColumn.DataPropertyName = "shijian";
            this.shijianDataGridViewTextBoxColumn.HeaderText = "shijian";
            this.shijianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shijianDataGridViewTextBoxColumn.Name = "shijianDataGridViewTextBoxColumn";
            this.shijianDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 553);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form8";
            this.Text = "每日明细";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meirixiaolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private sqwDataSet5 sqwDataSet5;
        private System.Windows.Forms.BindingSource meirixiaolBindingSource;
        private sqwDataSet5TableAdapters.meirixiaolTableAdapter meirixiaolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jinerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yinglDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zfbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhaolingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhaozyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shijianDataGridViewTextBoxColumn;
    }
}