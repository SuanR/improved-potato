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
    public partial class Classify : Form
    {
        public Classify()
        {
            InitializeComponent();
        }

        public string ascertain = "无";

        private void Classify_Load(object sender, EventArgs e)
        {
            ClassifyView();
        }
        /// <summary>
        /// 动态添加listview项
        /// </summary>
        public void ClassifyView()
        {
            this.listClassify.Items.Clear();
            NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
            DataTable dt = propertyClass.SelectListByWhere("");
            foreach (DataRow table in dt.Rows)
            {
                ListViewItem item = new ListViewItem(table["CalssName"].ToString());
                item.SubItems.Add(table["ClassID"].ToString());
                this.listClassify.Items.Add(item);
            }
        }
        /// <summary>
        /// 选中某行就显示某行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listClassify_Click(object sender, EventArgs e)
        {
            
                foreach (ListViewItem item in listClassify.Items)
                {
                    if (item.SubItems[0].Text == this.listClassify.SelectedItems[0].Text)                    {
                        this.txtClassID.Text = item.SubItems[1].Text;
                        this.txtClassName.Text = this.listClassify.SelectedItems[0].SubItems[0].Text;
                    }
                }
            

        }

        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtClassID.Text = "";
            this.txtClassName.Text = "";
            this.txtClassID.ReadOnly = false;
            ascertain = "添加";
        }
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtClassID.ReadOnly = true;
            ascertain = "删除";

        }
        /// <summary>
        /// 修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAmend_Click(object sender, EventArgs e)
        {
            this.txtClassID.ReadOnly = true;
            ascertain = "修改";
        }
        /// <summary>
        /// 确定保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKeep_Click(object sender, EventArgs e)
        {
            NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();

            switch (ascertain)
            {
                case "无":
                    MessageBox.Show("请选择添加,修改或删除!!!");
                    break;
                case "添加":
                    propertyClass.ClassID = this.txtClassID.Text;
                    propertyClass.ClassNAme = this.txtClassName.Text;
                    if (propertyClass.Add())
                    {
                        MessageBox.Show("添加成功!");
                        this.txtClassID.Text = "";
                        this.txtClassName.Text = "";
                        this.txtClassID.ReadOnly = true;
                        ClassifyView();
                    }
                    else
                    {
                        MessageBox.Show("添加失败!");
                    }
                    break;
                case "修改":
                    if (this.txtClassID.Text == "")
                    {
                        MessageBox.Show("请选择你要修改的项!");
                    }
                    else
                    {
                        if (this.txtClassName.Text == "")
                        {
                            MessageBox.Show("类型名不能为空!");
                        }
                        else
                        {
                            propertyClass.ClassID = this.txtClassID.Text;
                            propertyClass.ClassNAme = this.txtClassName.Text;
                            if (propertyClass.Update())
                            {
                                MessageBox.Show("修改成功!");
                                this.txtClassID.Text = "";
                                this.txtClassName.Text = "";
                                ClassifyView();
                            }
                            else
                            {
                                MessageBox.Show("修改失败!");
                            }
                        }
                    }
                    break;
                case "删除":
                    if (this.txtClassID.Text == "")
                    {
                        MessageBox.Show("请选择你要删除的项!");
                    }
                    else
                    {
                        if (propertyClass.Delete(this.txtClassID.Text))
                        {
                            MessageBox.Show("删除成功!");
                            this.txtClassID.Text = "";
                            this.txtClassName.Text = "";                            
                            ClassifyView();
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

