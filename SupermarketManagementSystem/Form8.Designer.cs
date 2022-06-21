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
            this.meirixiaolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqwDataSet5 = new SupermarketManagementSystem.sqwDataSet5();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.meirixiaolTableAdapter = new SupermarketManagementSystem.sqwDataSet5TableAdapters.meirixiaolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.meirixiaolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // meirixiaolBindingSource
            // 
            this.meirixiaolBindingSource.DataMember = "meirixiaol";
            this.meirixiaolBindingSource.DataSource = this.sqwDataSet5;
            // 
            // sqwDataSet5
            // 
            this.sqwDataSet5.DataSetName = "sqwDataSet5";
            this.sqwDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(563, 496);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 32);
            this.button12.TabIndex = 33;
            this.button12.Text = "更多";
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
            // meirixiaolTableAdapter
            // 
            this.meirixiaolTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(977, 553);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "Form8";
            this.Text = "更多";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meirixiaolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqwDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private sqwDataSet5 sqwDataSet5;
        private System.Windows.Forms.BindingSource meirixiaolBindingSource;
        private sqwDataSet5TableAdapters.meirixiaolTableAdapter meirixiaolTableAdapter;
    }
}