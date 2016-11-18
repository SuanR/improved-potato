namespace 通用固定资产管理系统
{
    partial class FormBorrow
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.ComboBox();
            this.NowDate = new System.Windows.Forms.DateTimePicker();
            this.Predict_date = new System.Windows.Forms.DateTimePicker();
            this.Borrow_Date = new System.Windows.Forms.DateTimePicker();
            this.Detail = new System.Windows.Forms.TextBox();
            this.Company = new System.Windows.Forms.TextBox();
            this.Borrow_sum = new System.Windows.Forms.TextBox();
            this.Predict_money = new System.Windows.Forms.TextBox();
            this.Money = new System.Windows.Forms.TextBox();
            this.F_proID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(155, 372);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CustomerID);
            this.groupBox1.Controls.Add(this.NowDate);
            this.groupBox1.Controls.Add(this.Predict_date);
            this.groupBox1.Controls.Add(this.Borrow_Date);
            this.groupBox1.Controls.Add(this.Detail);
            this.groupBox1.Controls.Add(this.Company);
            this.groupBox1.Controls.Add(this.Borrow_sum);
            this.groupBox1.Controls.Add(this.Predict_money);
            this.groupBox1.Controls.Add(this.Money);
            this.groupBox1.Controls.Add(this.F_proID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(173, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(464, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "归还";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "租借";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerID.FormattingEnabled = true;
            this.CustomerID.Location = new System.Drawing.Point(53, 93);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(94, 20);
            this.CustomerID.TabIndex = 3;
            // 
            // NowDate
            // 
            this.NowDate.Enabled = false;
            this.NowDate.Location = new System.Drawing.Point(254, 41);
            this.NowDate.Name = "NowDate";
            this.NowDate.Size = new System.Drawing.Size(122, 21);
            this.NowDate.TabIndex = 2;
            // 
            // Predict_date
            // 
            this.Predict_date.Location = new System.Drawing.Point(65, 41);
            this.Predict_date.Name = "Predict_date";
            this.Predict_date.Size = new System.Drawing.Size(100, 21);
            this.Predict_date.TabIndex = 2;
            // 
            // Borrow_Date
            // 
            this.Borrow_Date.Location = new System.Drawing.Point(355, 14);
            this.Borrow_Date.Name = "Borrow_Date";
            this.Borrow_Date.Size = new System.Drawing.Size(168, 21);
            this.Borrow_Date.TabIndex = 2;
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(193, 93);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(183, 21);
            this.Detail.TabIndex = 1;
            // 
            // Company
            // 
            this.Company.Location = new System.Drawing.Point(230, 68);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(293, 21);
            this.Company.TabIndex = 1;
            // 
            // Borrow_sum
            // 
            this.Borrow_sum.Location = new System.Drawing.Point(230, 14);
            this.Borrow_sum.Name = "Borrow_sum";
            this.Borrow_sum.Size = new System.Drawing.Size(60, 21);
            this.Borrow_sum.TabIndex = 1;
            // 
            // Predict_money
            // 
            this.Predict_money.Location = new System.Drawing.Point(441, 41);
            this.Predict_money.Name = "Predict_money";
            this.Predict_money.Size = new System.Drawing.Size(82, 21);
            this.Predict_money.TabIndex = 1;
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(65, 68);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(100, 21);
            this.Money.TabIndex = 1;
            // 
            // F_proID
            // 
            this.F_proID.Location = new System.Drawing.Point(65, 14);
            this.F_proID.Name = "F_proID";
            this.F_proID.ReadOnly = true;
            this.F_proID.Size = new System.Drawing.Size(100, 21);
            this.F_proID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "经办人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "实际收益";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "拟还日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "预计收益";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "租借日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "说明";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "租借公司";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "实际归还时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "租借数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "资产编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(173, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(523, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "FormBorrow";
            this.Text = "FormBorrow";
            this.Load += new System.EventHandler(this.FormBorrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CustomerID;
        private System.Windows.Forms.DateTimePicker NowDate;
        private System.Windows.Forms.DateTimePicker Predict_date;
        private System.Windows.Forms.DateTimePicker Borrow_Date;
        private System.Windows.Forms.TextBox Detail;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.TextBox Borrow_sum;
        private System.Windows.Forms.TextBox Predict_money;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.TextBox F_proID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}