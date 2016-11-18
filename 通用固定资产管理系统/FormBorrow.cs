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
        private void FormBorrow_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource = goods.dataBorrowLoad();
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
            this.F_proID.Text = this.dataGridView1.CurrentRow.Cells["F_proID"].Value.ToString();
            this.Borrow_sum.Text = this.dataGridView1.CurrentRow.Cells["Borrow_sum"].Value.ToString();
            this.Borrow_Date.Text = this.dataGridView1.CurrentRow.Cells["Borrow_Date"].Value.ToString();
            this.Predict_date.Text = this.dataGridView1.CurrentRow.Cells["Predict_date"].Value.ToString();
            this.NowDate.Text = this.dataGridView1.CurrentRow.Cells["NowDate"].Value.ToString();
            this.Predict_money.Text = this.dataGridView1.CurrentRow.Cells["Predict_money"].Value.ToString();
            this.Money.Text = this.dataGridView1.CurrentRow.Cells["Money"].Value.ToString();
            this.Company.Text = this.dataGridView1.CurrentRow.Cells["Company"].Value.ToString();
            this.CustomerID.SelectedValue = this.dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
            this.Detail.Text = this.dataGridView1.CurrentRow.Cells["Detail"].Value.ToString();
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
                    }
                    else
                    {
                        MessageBox.Show("租借失败!");
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
