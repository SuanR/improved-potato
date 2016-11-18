using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通用固定资产管理系统
{
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
        }
        NewFolder1.Department dep = new NewFolder1.Department();
        public string ascertain = "无";
        private void department_Load(object sender, EventArgs e)
        {
            listdepartmentLoad();
        }
        /// <summary>
        /// 加载listview事件
        /// </summary>
        public void listdepartmentLoad()
        {
            this.listdepartment.Items.Clear();
            DataTable dt = dep.SelectListByWhere("");
            foreach (DataRow table in dt.Rows)
            {
                ListViewItem item = new ListViewItem(table["DepName"].ToString());
                item.SubItems.Add(table["DepID"].ToString());
                this.listdepartment.Items.Add(item);
            }
        }
        /// <summary>
        /// 单击listView的点击某一项然后在旁边的文本框中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listdepartment_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listdepartment.Items)
            {
                if (item.SubItems[0].Text == this.listdepartment.SelectedItems[0].Text)
                {
                    this.txtName.Text = item.SubItems[0].Text;
                    this.txtID.Text = item.SubItems[1].Text;
                }
            }
        }
        /// <summary>
        /// 新增按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ascertain = "新增";
            this.txtID.ReadOnly = false;
            this.txtID.Text = "";
            this.txtName.Text = "";
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ascertain = "修改";
            this.txtID.ReadOnly = true;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ascertain = "删除";
            this.txtID.ReadOnly = true;
        }
        /// <summary>
        /// 确定保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            this.txtID.ReadOnly = true;
            switch (ascertain)
            {
                case "无":
                    MessageBox.Show("请选择添加,修改或删除!!!");
                    break;
                case "新增":
                    if (this.txtID.Text == "" || this.txtName.Text == "")
                    {
                        MessageBox.Show("编号或者姓名不能不空!");
                    }
                    else
                    {
                        dep.DepID = this.txtID.Text;
                        dep.DepNAme = this.txtName.Text;
                        if (dep.Add())
                        {
                            MessageBox.Show("添加成功!");
                            this.txtName.Text = "";
                            this.txtID.Text = "";
                            listdepartmentLoad();
                        }
                        else
                        {
                            MessageBox.Show("添加失败!");
                        }
                    }
                    break;
                case "修改":
                    if (this.txtID.Text == "")
                    {
                        MessageBox.Show("请选择修改项");
                    }
                    else
                    {
                        if (this.txtName.Text == "")
                        {
                            MessageBox.Show("部门名称不能为空!");
                        }
                        else
                        {
                            dep.DepID = this.txtID.Text;
                            dep.DepNAme = this.txtName.Text;
                            if (dep.Update())
                            {
                                MessageBox.Show("修改成功!");
                                this.txtID.Text = "";
                                this.txtName.Text = "";
                                listdepartmentLoad();
                            }
                            else
                            {
                                MessageBox.Show("修改失败!");
                            }
                        }

                    }

                    break;
                case "删除":
                    if (this.txtID.Text == "")
                    {
                        MessageBox.Show("请选择删除项");
                    }
                    else
                    {                       
                        if (dep.Delete(this.txtID.Text))
                        {
                            MessageBox.Show("删除成功!");
                            this.txtID.Text = "";
                            this.txtName.Text = "";
                            listdepartmentLoad();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }
                    break;

            }
        }
    }
}
