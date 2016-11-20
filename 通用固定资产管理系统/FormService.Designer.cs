namespace 通用固定资产管理系统
{
    partial class FormService
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
            this.Service_sum = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Predict_date = new System.Windows.Forms.DateTimePicker();
            this.NowDate = new System.Windows.Forms.DateTimePicker();
            this.Service_Date = new System.Windows.Forms.DateTimePicker();
            this.Company = new System.Windows.Forms.TextBox();
            this.Detail = new System.Windows.Forms.TextBox();
            this.Breakdown = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Service_txt = new System.Windows.Forms.TextBox();
            this.NowCost = new System.Windows.Forms.TextBox();
            this.F_proID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.treeView1.Size = new System.Drawing.Size(205, 419);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Service_sum);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.Predict_date);
            this.groupBox1.Controls.Add(this.NowDate);
            this.groupBox1.Controls.Add(this.Service_Date);
            this.groupBox1.Controls.Add(this.Company);
            this.groupBox1.Controls.Add(this.Detail);
            this.groupBox1.Controls.Add(this.Breakdown);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.Service_txt);
            this.groupBox1.Controls.Add(this.NowCost);
            this.groupBox1.Controls.Add(this.F_proID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Service_sum
            // 
            this.Service_sum.Location = new System.Drawing.Point(254, 14);
            this.Service_sum.Name = "Service_sum";
            this.Service_sum.Size = new System.Drawing.Size(63, 21);
            this.Service_sum.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(516, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "接收";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(436, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "送修";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Predict_date
            // 
            this.Predict_date.Location = new System.Drawing.Point(87, 44);
            this.Predict_date.Name = "Predict_date";
            this.Predict_date.Size = new System.Drawing.Size(102, 21);
            this.Predict_date.TabIndex = 2;
            // 
            // NowDate
            // 
            this.NowDate.Enabled = false;
            this.NowDate.Location = new System.Drawing.Point(278, 47);
            this.NowDate.Name = "NowDate";
            this.NowDate.Size = new System.Drawing.Size(102, 21);
            this.NowDate.TabIndex = 2;
            // 
            // Service_Date
            // 
            this.Service_Date.Location = new System.Drawing.Point(382, 14);
            this.Service_Date.Name = "Service_Date";
            this.Service_Date.Size = new System.Drawing.Size(195, 21);
            this.Service_Date.TabIndex = 2;
            // 
            // Company
            // 
            this.Company.Location = new System.Drawing.Point(254, 77);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(323, 21);
            this.Company.TabIndex = 1;
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(41, 138);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(389, 21);
            this.Detail.TabIndex = 1;
            // 
            // Breakdown
            // 
            this.Breakdown.Location = new System.Drawing.Point(65, 108);
            this.Breakdown.Name = "Breakdown";
            this.Breakdown.Size = new System.Drawing.Size(311, 21);
            this.Breakdown.TabIndex = 1;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(469, 47);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(108, 21);
            this.Cost.TabIndex = 1;
            // 
            // Service_txt
            // 
            this.Service_txt.Location = new System.Drawing.Point(436, 108);
            this.Service_txt.Name = "Service_txt";
            this.Service_txt.Size = new System.Drawing.Size(141, 21);
            this.Service_txt.TabIndex = 1;
            // 
            // NowCost
            // 
            this.NowCost.Location = new System.Drawing.Point(89, 77);
            this.NowCost.Name = "NowCost";
            this.NowCost.Size = new System.Drawing.Size(100, 21);
            this.NowCost.TabIndex = 1;
            // 
            // F_proID
            // 
            this.F_proID.Location = new System.Drawing.Point(65, 14);
            this.F_proID.Name = "F_proID";
            this.F_proID.ReadOnly = true;
            this.F_proID.Size = new System.Drawing.Size(124, 21);
            this.F_proID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "修理情况";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "预计修理费用";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "送修日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "修理公司";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "实际修完日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "送修数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "说明";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "故障原因";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "实际修理费用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "预计完修日期";
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
            this.groupBox2.Location = new System.Drawing.Point(223, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(577, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "FormService";
            this.Text = "FormService";
            this.Load += new System.EventHandler(this.FormService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox F_proID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker Predict_date;
        private System.Windows.Forms.DateTimePicker NowDate;
        private System.Windows.Forms.DateTimePicker Service_Date;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.TextBox Detail;
        private System.Windows.Forms.TextBox Breakdown;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Service_txt;
        private System.Windows.Forms.TextBox NowCost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Service_sum;
    }
}