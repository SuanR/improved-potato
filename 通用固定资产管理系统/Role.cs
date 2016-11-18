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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }
        public string ascertain = "无";
        NewFolder1.Role role = new NewFolder1.Role();
        /// <summary>
        /// 角色表窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Role_Load(object sender, EventArgs e)
        {
            RolelistViewLoad();
        }
        /// <summary>
        /// 加载listView事件
        /// </summary>
        public void RolelistViewLoad()
        {
            this.listRole.Items.Clear();
            DataTable dt = role.SelectListByWhere("");
            foreach (DataRow table in dt.Rows)
            {
                ListViewItem item = new ListViewItem(table["RoleName"].ToString());
                item.SubItems.Add(table["RoleID"].ToString());
                item.SubItems.Add(table["RoleTxt"].ToString());
                this.listRole.Items.Add(item);
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ascertain = "新增";
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            ascertain = "删除";
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ascertain = "修改";
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            switch (ascertain)
            {
                case "无":
                    MessageBox.Show("请选择添加,修改或删除!!!");
                    break;
                case "新增":
                    if (this.txtName.Text == "" || this.txt.Text == "")
                    {
                        MessageBox.Show("请填写角色名称和角色描述!!!");
                    }
                    else
                    {
                        role.RoleName = this.txtName.Text;
                        role.RoleTxt = this.txt.Text;
                        role.RoleID = 1;
                        if (role.Add())
                        {
                            MessageBox.Show("新增成功!");
                            this.txt.Text = "";
                            this.txtName.Text = "";
                            RolelistViewLoad();
                        }
                        else
                        {
                            MessageBox.Show("新增失败!");
                        }
                    }
                    break;



                case "修改":
                    if (Convert.ToString(role.RoleID) == "")
                    {
                        MessageBox.Show("请选择要修改项!!!");
                    }
                    else
                    {
                        if (this.txt.Text == "" || this.txtName.Text == "")
                        {
                            MessageBox.Show("角色名或角色描述不能为空!!!");
                        }
                        else
                        {
                            role.RoleTxt = this.txt.Text;
                            role.RoleName = this.txtName.Text;
                            if (role.Update())
                            {
                                MessageBox.Show("修改成功!!!");
                                this.txt.Text = "";
                                this.txtName.Text = "";
                                RolelistViewLoad();
                            }
                            else
                            {
                                MessageBox.Show("修改失败!");
                            }
                        }
                    }
                    break;



                case "删除":
                    if (Convert.ToString(role.RoleID) == "")
                    {
                        MessageBox.Show("请选择要删除项!!!");
                    }
                    else
                    {
                        if (role.Delete(""))
                        {
                            MessageBox.Show("删除成功!!!");
                            this.txt.Text = "";
                            this.txtName.Text = "";
                            RolelistViewLoad();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }

                    }

                    break;
            }
        }
        /// <summary>
        /// 单击listView的点击某一项然后在旁边的文本框中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listRole_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listRole.Items)
            {
                if (item.SubItems[0].Text == this.listRole.SelectedItems[0].Text)
                {
                    role.RoleID = Convert.ToInt32(item.SubItems[1].Text);
                    this.txt.Text = item.SubItems[2].Text;
                    this.txtName.Text = this.listRole.SelectedItems[0].SubItems[0].Text;
                }
            }
        }
    }
}
