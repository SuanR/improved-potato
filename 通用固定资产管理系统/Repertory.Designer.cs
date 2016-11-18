namespace 通用固定资产管理系统
{
    partial class ReperTory
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
            this.listRepertory = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepID = new System.Windows.Forms.TextBox();
            this.txtRepName = new System.Windows.Forms.TextBox();
            this.txtRepPosition = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPreserve = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRepertory
            // 
            this.listRepertory.Location = new System.Drawing.Point(12, 12);
            this.listRepertory.Name = "listRepertory";
            this.listRepertory.Size = new System.Drawing.Size(121, 251);
            this.listRepertory.TabIndex = 0;
            this.listRepertory.UseCompatibleStateImageBehavior = false;
            this.listRepertory.View = System.Windows.Forms.View.List;
            this.listRepertory.Click += new System.EventHandler(this.listRepertory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "仓库编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "仓库位置";
            // 
            // txtRepID
            // 
            this.txtRepID.Location = new System.Drawing.Point(230, 43);
            this.txtRepID.Name = "txtRepID";
            this.txtRepID.ReadOnly = true;
            this.txtRepID.Size = new System.Drawing.Size(100, 21);
            this.txtRepID.TabIndex = 2;
            // 
            // txtRepName
            // 
            this.txtRepName.Location = new System.Drawing.Point(230, 79);
            this.txtRepName.Name = "txtRepName";
            this.txtRepName.Size = new System.Drawing.Size(149, 21);
            this.txtRepName.TabIndex = 1;
            // 
            // txtRepPosition
            // 
            this.txtRepPosition.Location = new System.Drawing.Point(230, 113);
            this.txtRepPosition.Multiline = true;
            this.txtRepPosition.Name = "txtRepPosition";
            this.txtRepPosition.Size = new System.Drawing.Size(149, 99);
            this.txtRepPosition.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPreserve
            // 
            this.btnPreserve.Location = new System.Drawing.Point(370, 240);
            this.btnPreserve.Name = "btnPreserve";
            this.btnPreserve.Size = new System.Drawing.Size(53, 23);
            this.btnPreserve.TabIndex = 3;
            this.btnPreserve.Text = "保存";
            this.btnPreserve.UseVisualStyleBackColor = true;
            this.btnPreserve.Click += new System.EventHandler(this.btnPreserve_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(302, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ReperTory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 275);
            this.Controls.Add(this.btnPreserve);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRepPosition);
            this.Controls.Add(this.txtRepName);
            this.Controls.Add(this.txtRepID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listRepertory);
            this.Name = "ReperTory";
            this.Text = "Repertory";
            this.Load += new System.EventHandler(this.Repertory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listRepertory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepID;
        private System.Windows.Forms.TextBox txtRepName;
        private System.Windows.Forms.TextBox txtRepPosition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPreserve;
        private System.Windows.Forms.Button btnUpdate;
    }
}