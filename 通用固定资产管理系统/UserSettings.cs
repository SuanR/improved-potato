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
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
        }
        public string ascertain = "无";
        NewFolder1.Customer customer = new NewFolder1.Customer();
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserSettings_Load(object sender, EventArgs e)
        {
            listuserLoad();
            Dep();
            Role();
        }
        /// <summary>
        /// 在listView里加载数据库信息
        /// </summary>
        public void listuserLoad()
        {
            this.listuser.Items.Clear();
            DataTable dt = customer.SelectListByWhere("");
            foreach (DataRow table in dt.Rows)
            {
                ListViewItem item = new ListViewItem(table["CustomerName"].ToString());
                item.SubItems.Add(table["CustomerID"].ToString());
                item.SubItems.Add(table["Login"].ToString());
                item.SubItems.Add(table["Pwd"].ToString());
                item.SubItems.Add(table["DepID"].ToString());
                item.SubItems.Add(table["RoleID"].ToString());
                this.listuser.Items.Add(item);
            }
        }
        /// <summary>
        /// 加载所属部门的下拉列表
        /// </summary>
        public void Dep()
        {
            NewFolder1.Customer customer = new NewFolder1.Customer();
            DataTable dt = customer.comDepID();
            comDepID.DataSource = dt;
            comDepID.ValueMember = "DepID";
            comDepID.DisplayMember = "DepName";
        }
        /// <summary>
        /// 加载所属角色的下拉列表
        /// </summary>
        public void Role()
        {
            NewFolder1.Customer customer = new NewFolder1.Customer();
            DataTable dt = customer.role();
            comRoleID.DataSource = dt;
            comRoleID.ValueMember = "RoleID";
            comRoleID.DisplayMember = "RoleName";

        }
        /// <summary>
        /// 部门下拉列表的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comDepID_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 角色下拉列表的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comRoleID_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击listView的点击某一项然后在旁边的文本框中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listuser_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listuser.Items)
            {
                if (item.SubItems[0].Text == this.listuser.SelectedItems[0].Text)
                {
                    this.txtLogin.Text = item.SubItems[2].Text;
                    this.txtCustomerName.Text = this.listuser.SelectedItems[0].SubItems[0].Text;
                    // this.comRoleID.Items.Add(item.SubItems[5].Text);
                    this.comDepID.SelectedValue = item.SubItems[4].Text;
                    this.comRoleID.SelectedValue = item.SubItems[5].Text;
                    this.txtPwd.Text = item.SubItems[3].Text;
                    customer.CustomerID = Convert.ToInt32(item.SubItems[1].Text);
                }
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ascertain = "添加";
            this.txtCustomerName.Text = "";
            this.txtLogin.Text = "";
            this.txtPwd.Text = "";
            MessageBox.Show(ascertain);
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
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ascertain = "删除";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string comDepID="";
            switch (ascertain)
            {
                case "无":
                    MessageBox.Show("请选择添加,修改或删除!!!");
                    break;
                case "添加":
                    if (this.txtCustomerName.Text == "" || this.txtLogin.Text == "" || this.txtPwd.Text == "")
                    {
                        MessageBox.Show("文本框不能为空!");
                    }
                    else
                    {
                        customer.CustomerName = this.txtCustomerName.Text;
                        customer.Login = this.txtLogin.Text;
                        customer.Pwd = this.txtPwd.Text;
                        customer.RoleID = Convert.ToInt32(this.comRoleID.SelectedValue);
                        customer.DepID = Convert.ToString(this.comDepID.SelectedValue);
                        if (customer.Add())
                        {
                            MessageBox.Show("新增成功!");
                            this.txtCustomerName.Text = "";
                            this.txtLogin.Text = "";
                            this.txtPwd.Text = "";
                            listuserLoad();
                        }
                        else
                        {
                            MessageBox.Show("新增失败!");
                        }

                    }
                    break;
                case "修改":                    
                    comDepID = Convert.ToString(customer.CustomerID);
                    if (comDepID == "")
                    {
                        MessageBox.Show("请选择你要修改的项!");
                    }
                    else
                    {
                        customer.CustomerName = this.txtCustomerName.Text;
                        customer.Login = this.txtLogin.Text;
                        customer.Pwd = this.txtPwd.Text;
                        customer.RoleID = Convert.ToInt32(this.comRoleID.SelectedValue);
                        customer.DepID = Convert.ToString(this.comDepID.SelectedValue);

                        //customer.CustomerID=
                        if (customer.Update())
                        {
                            MessageBox.Show("修改成功!");
                            this.txtCustomerName.Text = "";
                            this.txtLogin.Text = "";
                            this.txtPwd.Text = "";
                            listuserLoad();
                        }
                        else
                        {
                            MessageBox.Show("修改失败!");
                        }
                    }
                    break;
                case "删除":                  
                    comDepID = Convert.ToString(customer.CustomerID);
                    if (comDepID == "")
                    {
                        MessageBox.Show("请选择你要删除的项!");
                    }
                    else
                    {
                        customer.CustomerName = this.txtCustomerName.Text;
                        customer.Login = this.txtLogin.Text;
                        customer.Pwd = this.txtPwd.Text;
                        customer.RoleID = Convert.ToInt32(this.comRoleID.SelectedValue);
                        customer.DepID = Convert.ToString(this.comDepID.SelectedValue);
                        //customer.CustomerID=
                        if (customer.Delete(comDepID))
                        {
                            MessageBox.Show("删除成功!");
                            this.txtCustomerName.Text = "";
                            this.txtLogin.Text = "";
                            this.txtPwd.Text = "";
                            listuserLoad();
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
