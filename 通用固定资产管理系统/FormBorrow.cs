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
    public partial class FormBorrow : Form
    {
        public FormBorrow()
        {
            InitializeComponent();
        }
        NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
        NewFolder1.Goods goods = new NewFolder1.Goods();
        NewFolder1.Borrow borrow = new NewFolder1.Borrow();
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBorrow_Load(object sender, EventArgs e)
        {
            dataLoad();
            treeLoad();
            comNameLoad();
        }
        /// <summary>
        /// 加载Tree
        /// </summary>
        public void treeLoad()
        {
            goods.SelectListByWhere("");
            propertyClass.SelectListByWhere("");
            foreach (DataRow pro in propertyClass.SelectListByWhere("").Rows)
            {
                TreeNode node = new TreeNode(pro["CalssName"].ToString());
                node.Tag = pro["ClassID"].ToString();
                this.treeView1.Nodes.Add(node);

                //遍历所有资产
                foreach (DataRow goodsNode in goods.SelectListByWhere("").Rows)
                {
                    if (pro["ClassID"].ToString() == goodsNode["ClassID"].ToString())
                    {
                        TreeNode subNode = new TreeNode(goodsNode["GoodsName"].ToString());
                        node.Nodes.Add(subNode);
                    }
                }
            }
        }
        /// <summary>
        /// 单击节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            goods.BorrowLoad(e.Node.Text);
            foreach (DataRow item in goods.BorrowLoad(e.Node.Text).Rows)
            {
                this.F_proID.Text = item["F_proID"].ToString();
            }
            dataGridView1.DataSource = goods.BorrowdataLoad(e.Node.Text);
        }
        /// <summary>
        /// data单击事件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentRow.Cells["ID"].Value.ToString() == "")
            {
                
                this.Borrow_sum.Text = "";
                this.Borrow_Date.Text = "";
                this.Predict_date.Text = "";
                this.NowDate.Text = "";
                this.Predict_money.Text = "";
                this.Money.Text = "";
                this.Company.Text = "";
                this.Detail.Text = "";
                this.button2.Enabled = false;
                this.button1.Enabled = true;
                this.NowDate.Enabled = false;
                this.Borrow_sum.Enabled = true;
                this.Borrow_Date.Enabled = true;
                this.Predict_date.Enabled = true;
            }
            else
            {
                this.Predict_date.Enabled = false;
                this.Borrow_Date.Enabled = false;
                this.Borrow_sum.Enabled = false;
                this.button2.Enabled = true;
                this.button1.Enabled = false;
                this.NowDate.Enabled = true;
                this.F_proID.Text = this.dataGridView1.CurrentRow.Cells["F_proID_Name"].Value.ToString();
                this.Borrow_sum.Text = this.dataGridView1.CurrentRow.Cells["Borrow_sum_Name"].Value.ToString();
                this.Borrow_Date.Text = this.dataGridView1.CurrentRow.Cells["Borrow_Date_Name"].Value.ToString();
                this.Predict_date.Text = this.dataGridView1.CurrentRow.Cells["Predict_date_Name"].Value.ToString();
                this.NowDate.Text = this.dataGridView1.CurrentRow.Cells["NowDate_Name"].Value.ToString();
                this.Predict_money.Text = this.dataGridView1.CurrentRow.Cells["Predict_money_Name"].Value.ToString();
                this.Money.Text = this.dataGridView1.CurrentRow.Cells["Money_Name"].Value.ToString();
                this.Company.Text = this.dataGridView1.CurrentRow.Cells["Company_Name"].Value.ToString();
                this.CustomerID.SelectedValue = this.dataGridView1.CurrentRow.Cells["CustomerID_Name"].Value.ToString();
                this.Detail.Text = this.dataGridView1.CurrentRow.Cells["Detail_Name"].Value.ToString();
            }

        }
        /// <summary>
        /// 经办人下拉列表
        /// </summary>
        public void comNameLoad()
        {
            CustomerID.Items.Clear();
            NewFolder1.Customer customer = new NewFolder1.Customer();
            DataTable dt = customer.SelectListByWhere("");
            CustomerID.DataSource = dt;//绑定数据库
            CustomerID.ValueMember = "CustomerID";//显示掩藏的值
            CustomerID.DisplayMember = "CustomerName";//最后加载出来的列
        }
        /// <summary>
        /// 租借按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Borrow_sum.Text == "" || this.Predict_money.Text == "")
            {
                MessageBox.Show("预计收入和租借数不能为空");
            }
            else
            {
                if (this.Money.Text == "")
                {
                    this.Money.Text = "0";
                }
                if (this.F_proID.Text == "")
                {
                    MessageBox.Show("请选择租借项");
                }
                else
                {
                    borrow.Borrow_Date = this.Borrow_Date.Value.ToString();
                    borrow.Borrow_sum = Convert.ToInt32(this.Borrow_sum.Text);
                    borrow.Company = this.Company.Text;
                    borrow.CustomerID = Convert.ToInt32(this.CustomerID.SelectedValue);
                    borrow.Detail = this.Detail.Text;
                    borrow.F_proID = this.F_proID.Text;
                    borrow.Money = Convert.ToInt32(this.Money.Text);
                    borrow.NowDate = null;
                    borrow.Predict_date = this.Predict_date.Value.ToString();
                    borrow.Predict_money = Convert.ToInt32(this.Predict_money.Text);
                    if (borrow.Add())
                    {
                        MessageBox.Show("租借成功!");
                        this.F_proID.Text = "";
                        this.Borrow_sum.Text = "";
                        this.Borrow_Date.Text = "";
                        this.Predict_date.Text = "";
                        this.NowDate.Text = "";
                        this.Predict_money.Text = "";
                        this.Money.Text = "";
                        this.Company.Text = "";
                        this.Detail.Text = "";
                        dataLoad();
                    }
                    else
                    {
                        MessageBox.Show("租借失败!");
                    }
                }

            }
        }
        /// <summary>
        /// 归还按钮的单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow.Cells["ID"].Value.ToString() != "")
            {
                if (this.Money.Text == "")
                {
                    MessageBox.Show("实际收益归还时不能为空!");
                }
                else
                {
                    borrow.BorrowID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                    borrow.Borrow_Date = this.Borrow_Date.Value.ToString();
                    borrow.Borrow_sum = Convert.ToInt32(this.Borrow_sum.Text);
                    borrow.Company = this.Company.Text;
                    borrow.CustomerID = Convert.ToInt32(this.CustomerID.SelectedValue);
                    borrow.Detail = this.Detail.Text;
                    borrow.F_proID = this.F_proID.Text;
                    borrow.Money = Convert.ToSingle(this.Money.Text);
                    borrow.NowDate = DateTime.Now.ToString();
                    borrow.Predict_date = this.Predict_date.Value.ToString();
                    borrow.Predict_money = Convert.ToSingle(this.Predict_money.Text);
                    if (borrow.Update())
                    {
                        MessageBox.Show("归还成功!");
                        this.F_proID.Text = "";
                        this.Borrow_sum.Text = "";
                        this.Borrow_Date.Text = "";
                        this.Predict_date.Text = "";
                        this.NowDate.Text = "";
                        this.Predict_money.Text = "";
                        this.Money.Text = "";
                        this.Company.Text = "";
                        this.Detail.Text = "";
                        dataLoad();
                    }
                    else
                    {
                        MessageBox.Show("归还失败!");
                    }
                }

            }
        }
        public void dataLoad()
        {
            this.dataGridView1.DataSource = "";
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource = goods.dataBorrowLoad();
        }
    }
}
