namespace 通用固定资产管理系统
{
    partial class Role
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
            this.listRole = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRole
            // 
            this.listRole.Location = new System.Drawing.Point(12, 12);
            this.listRole.Name = "listRole";
            this.listRole.Size = new System.Drawing.Size(121, 253);
            this.listRole.TabIndex = 0;
            this.listRole.UseCompatibleStateImageBehavior = false;
            this.listRole.View = System.Windows.Forms.View.List;
            this.listRole.Click += new System.EventHandler(this.listRole_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "角色名";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(152, 82);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(67, 15);
            this.lblTxt.TabIndex = 1;
            this.lblTxt.Text = "角色描述";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 25);
            this.txtName.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(225, 79);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(167, 120);
            this.txt.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(155, 205);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(50, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(235, 205);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(50, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(392, 205);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(50, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "保存";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 277);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listRole);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btn;
    }
}