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
    public partial class ReperTory : Form
    {
        public ReperTory()
        {
            InitializeComponent();
        }

        public string ascertain = "无";

       
        /// <summary>
        /// 动态加载list
        /// </summary>
        public void Repertoryliew()
        {
            this.listRepertory.Items.Clear();
            NewFolder1.Repertory repertory = new NewFolder1.Repertory();
            DataTable dt = repertory.SelectListByWhere("");
            foreach (DataRow table in dt.Rows)
            {
                ListViewItem item = new ListViewItem(table["RepName"].ToString());
                item.SubItems.Add(table["RepID"].ToString());
                item.SubItems.Add(table["RepPosition"].ToString());
                this.listRepertory.Items.Add(item);
            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Repertory_Load(object sender, EventArgs e)
        {
            Repertoryliew();

        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ascertain = "新增";
            this.txtRepID.Text = "";
            this.txtRepName.Text = "";
            this.txtRepPosition.Text = "";
            this.txtRepID.ReadOnly = false;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtRepID.ReadOnly = true;
            ascertain = "删除";
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.txtRepID.ReadOnly = true;
            ascertain = "修改";
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreserve_Click(object sender, EventArgs e)
        {
            NewFolder1.Repertory reperTory = new NewFolder1.Repertory();
            switch (ascertain)
            {
                case "无":
                    MessageBox.Show("请选择添加,修改或删除!!!");
                    break;


                case "新增":
                    if (this.txtRepID.Text == "" || this.txtRepName.Text == "" || this.txtRepPosition.Text == "")
                    {
                        MessageBox.Show("文本框不能为空!");
                    }
                    else
                    {
                        reperTory.RepID = this.txtRepID.Text;
                        reperTory.RepName = this.txtRepName.Text;
                        reperTory.RepPosition = this.txtRepPosition.Text;
                        if (reperTory.Add())
                        {
                            MessageBox.Show("添加成功!");
                            this.txtRepID.Text = "";
                            this.txtRepName.Text = "";
                            this.txtRepPosition.Text = "";
                            this.txtRepID.ReadOnly = true;
                            Repertoryliew();
                        }
                        else
                        {
                            MessageBox.Show("添加失败!");
                            this.txtRepID.Text = "";
                            this.txtRepName.Text = "";
                            this.txtRepPosition.Text = "";
                        }
                    }
                    break;


                case "修改":
                    if (this.txtRepID.Text == "")
                    {
                        MessageBox.Show("请选择你要修改的项!");
                    }
                    else
                    {
                        if (this.txtRepName.Text == ""|| this.txtRepPosition.Text == "")
                        {
                            MessageBox.Show("不能为空!");
                        }
                        else
                        {
                            reperTory.RepID= this.txtRepID.Text;
                            reperTory.RepName = this.txtRepName.Text;
                            reperTory.RepPosition = this.txtRepPosition.Text;
                            if (reperTory.Update())
                            {
                                MessageBox.Show("修改成功!");
                                this.txtRepID.Text = "";
                                this.txtRepName.Text = "";
                                this.txtRepPosition.Text = "";
                                Repertoryliew();
                            }
                            else
                            {
                                MessageBox.Show("修改失败!");
                            }
                        }
                    }
                    break;


                case "删除":
                    if (this.txtRepID.Text == "")
                    {
                        MessageBox.Show("请选择你要删除的项!");
                    }
                    else
                    {
                        if (reperTory.Delete(this.txtRepID.Text))
                        {
                            MessageBox.Show("删除成功!");
                            this.txtRepID.Text = "";
                            this.txtRepName.Text = "";
                            this.txtRepPosition.Text = "";
                            Repertoryliew();
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
        private void listRepertory_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listRepertory.Items)
            {
                if (item.SubItems[0].Text == this.listRepertory.SelectedItems[0].Text)
                {
                    this.txtRepID.Text = item.SubItems[1].Text;
                    this.txtRepPosition.Text = item.SubItems[2].Text;
                    this.txtRepName.Text = this.listRepertory.SelectedItems[0].SubItems[0].Text;
                }
            }
        }
    }
}
