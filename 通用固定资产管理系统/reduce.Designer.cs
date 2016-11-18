namespace 通用固定资产管理系统
{
    partial class Reduce
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.txtClearIncome = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWhy = new System.Windows.Forms.TextBox();
            this.txtReduce_Sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClearCost = new System.Windows.Forms.TextBox();
            this.comMode = new System.Windows.Forms.ComboBox();
            this.comName = new System.Windows.Forms.ComboBox();
            this.txtF_proID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TimeReduce_date = new System.Windows.Forms.DateTimePicker();
            this.listNode = new System.Windows.Forms.TreeView();
            this.ReduceGoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reduce_Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reduce_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Why = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeReduce_date);
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.txtClearIncome);
            this.groupBox1.Controls.Add(this.txtDetail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWhy);
            this.groupBox1.Controls.Add(this.txtReduce_Sum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClearCost);
            this.groupBox1.Controls.Add(this.comMode);
            this.groupBox1.Controls.Add(this.comName);
            this.groupBox1.Controls.Add(this.txtF_proID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(443, 70);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(57, 23);
            this.btn.TabIndex = 12;
            this.btn.Text = "确定";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtClearIncome
            // 
            this.txtClearIncome.Location = new System.Drawing.Point(426, 43);
            this.txtClearIncome.Name = "txtClearIncome";
            this.txtClearIncome.Size = new System.Drawing.Size(85, 21);
            this.txtClearIncome.TabIndex = 11;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(309, 73);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(111, 21);
            this.txtDetail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "说明";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "清理收入";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "减少方式";
            // 
            // txtWhy
            // 
            this.txtWhy.Location = new System.Drawing.Point(245, 43);
            this.txtWhy.Name = "txtWhy";
            this.txtWhy.Size = new System.Drawing.Size(116, 21);
            this.txtWhy.TabIndex = 9;
            // 
            // txtReduce_Sum
            // 
            this.txtReduce_Sum.Location = new System.Drawing.Point(261, 14);
            this.txtReduce_Sum.Name = "txtReduce_Sum";
            this.txtReduce_Sum.Size = new System.Drawing.Size(66, 21);
            this.txtReduce_Sum.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "减少数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "减少原因";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "经办人";
            // 
            // txtClearCost
            // 
            this.txtClearCost.Location = new System.Drawing.Point(65, 73);
            this.txtClearCost.Name = "txtClearCost";
            this.txtClearCost.Size = new System.Drawing.Size(68, 21);
            this.txtClearCost.TabIndex = 5;
            // 
            // comMode
            // 
            this.comMode.FormattingEnabled = true;
            this.comMode.Items.AddRange(new object[] {
            "亏损",
            "丢失",
            "损坏",
            "正常减少"});
            this.comMode.Location = new System.Drawing.Point(392, 14);
            this.comMode.Name = "comMode";
            this.comMode.Size = new System.Drawing.Size(119, 20);
            this.comMode.TabIndex = 4;
            // 
            // comName
            // 
            this.comName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comName.FormattingEnabled = true;
            this.comName.Location = new System.Drawing.Point(186, 73);
            this.comName.Name = "comName";
            this.comName.Size = new System.Drawing.Size(77, 20);
            this.comName.TabIndex = 4;
            // 
            // txtF_proID
            // 
            this.txtF_proID.Location = new System.Drawing.Point(65, 14);
            this.txtF_proID.Name = "txtF_proID";
            this.txtF_proID.ReadOnly = true;
            this.txtF_proID.Size = new System.Drawing.Size(131, 21);
            this.txtF_proID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "清理费用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "减少日期";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReduceGoodsID,
            this.F_proID,
            this.GoodsName,
            this.Reduce_Sum,
            this.Reduce_date,
            this.Mode,
            this.CustomerName,
            this.ClearCost,
            this.ClearIncome,
            this.Why,
            this.Detail});
            this.dataGridView1.Location = new System.Drawing.Point(233, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(518, 432);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TimeReduce_date
            // 
            this.TimeReduce_date.CustomFormat = "yyyy-MM-DD\"";
            this.TimeReduce_date.Location = new System.Drawing.Point(65, 43);
            this.TimeReduce_date.Name = "TimeReduce_date";
            this.TimeReduce_date.Size = new System.Drawing.Size(115, 21);
            this.TimeReduce_date.TabIndex = 13;
            // 
            // listNode
            // 
            this.listNode.Location = new System.Drawing.Point(12, 20);
            this.listNode.Name = "listNode";
            this.listNode.Size = new System.Drawing.Size(215, 535);
            this.listNode.TabIndex = 3;
            this.listNode.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.listNode_NodeMouseClick);
            // 
            // ReduceGoodsID
            // 
            this.ReduceGoodsID.DataPropertyName = "ID";
            this.ReduceGoodsID.HeaderText = "ID";
            this.ReduceGoodsID.Name = "ReduceGoodsID";
            this.ReduceGoodsID.ReadOnly = true;
            this.ReduceGoodsID.Width = 42;
            // 
            // F_proID
            // 
            this.F_proID.DataPropertyName = "F_proID";
            this.F_proID.HeaderText = "资产编号";
            this.F_proID.Name = "F_proID";
            this.F_proID.ReadOnly = true;
            this.F_proID.Width = 78;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "资产名称";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            this.GoodsName.Width = 78;
            // 
            // Reduce_Sum
            // 
            this.Reduce_Sum.DataPropertyName = "Reduce_Sum";
            this.Reduce_Sum.HeaderText = "减少数量";
            this.Reduce_Sum.Name = "Reduce_Sum";
            this.Reduce_Sum.ReadOnly = true;
            this.Reduce_Sum.Width = 78;
            // 
            // Reduce_date
            // 
            this.Reduce_date.DataPropertyName = "Reduce_date";
            this.Reduce_date.HeaderText = "减少日期";
            this.Reduce_date.Name = "Reduce_date";
            this.Reduce_date.ReadOnly = true;
            this.Reduce_date.Width = 78;
            // 
            // Mode
            // 
            this.Mode.DataPropertyName = "Mode";
            this.Mode.HeaderText = "减少方式";
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            this.Mode.Width = 78;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "经办人";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 66;
            // 
            // ClearCost
            // 
            this.ClearCost.DataPropertyName = "ClearCost";
            this.ClearCost.HeaderText = "清理费用";
            this.ClearCost.Name = "ClearCost";
            this.ClearCost.ReadOnly = true;
            this.ClearCost.Width = 78;
            // 
            // ClearIncome
            // 
            this.ClearIncome.DataPropertyName = "ClearIncome";
            this.ClearIncome.HeaderText = "清理收入";
            this.ClearIncome.Name = "ClearIncome";
            this.ClearIncome.ReadOnly = true;
            this.ClearIncome.Width = 78;
            // 
            // Why
            // 
            this.Why.DataPropertyName = "Why";
            this.Why.HeaderText = "减少原因";
            this.Why.Name = "Why";
            this.Why.ReadOnly = true;
            this.Why.Width = 78;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "说明";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 54;
            // 
            // Reduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 555);
            this.Controls.Add(this.listNode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reduce";
            this.Text = "reduce";
            this.Load += new System.EventHandler(this.Reduce_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtClearIncome;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWhy;
        private System.Windows.Forms.TextBox txtReduce_Sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClearCost;
        private System.Windows.Forms.ComboBox comMode;
        private System.Windows.Forms.ComboBox comName;
        private System.Windows.Forms.TextBox txtF_proID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker TimeReduce_date;
        private System.Windows.Forms.TreeView listNode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReduceGoodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reduce_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reduce_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Why;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
    }
}