using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 通用固定资产管理系统
{
    public partial class Reduce : Form
    {
        public Reduce()
        {
            InitializeComponent();
        }
        NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
        NewFolder1.Goods goods = new NewFolder1.Goods();
        int cilck = 0;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reduce_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listNodeLoad();
            dataLoad();
            comNameLoad();
            if (this.txtF_proID.Text == "")
            {
                this.btn.Text = "添加";
            }
            else
            {
                this.btn.Text = "修改";
            }
        }
        /// <summary>
        /// 加载树节点
        /// </summary>
        public void listNodeLoad()
        {

            goods.SelectListByWhere("");
            propertyClass.SelectListByWhere("");
            foreach (DataRow pro in propertyClass.SelectListByWhere("").Rows)
            {
                TreeNode node = new TreeNode(pro["CalssName"].ToString());
                node.Tag = pro["ClassID"].ToString();
                this.listNode.Nodes.Add(node);

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
        /// 加载datatable
        /// </summary>
        public void dataLoad()
        {
            this.dataGridView1.DataSource = "";
            NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
            propertyClass.dataLoad();
            this.dataGridView1.DataSource = propertyClass.dataLoad();
        }
        /// <summary>
        /// 经办人下拉列表
        /// </summary>
        public void comNameLoad()
        {
            comName.Items.Clear();
            NewFolder1.Customer customer = new NewFolder1.Customer();
            DataTable dt = customer.SelectListByWhere("");
            comName.DataSource = dt;//绑定数据库
            comName.ValueMember = "CustomerID";//显示掩藏的值
            comName.DisplayMember = "CustomerName";//最后加载出来的列
        }
        /// <summary>
        /// 单击节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listNode_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.dataGridView1.DataSource = "";
            NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
            this.dataGridView1.DataSource = propertyClass.SetPro(e.Node.Text);
            if (this.txtF_proID.Text == "")
            {
                this.btn.Text = "添加";
            }
            else
            {
                this.btn.Text = "修改";
            }
        }
        /// <summary>
        /// datatable单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtF_proID.Text = this.dataGridView1.CurrentRow.Cells["F_proID"].Value.ToString();
            this.txtDetail.Text = this.dataGridView1.CurrentRow.Cells["Detail"].Value.ToString();
            this.txtClearCost.Text = this.dataGridView1.CurrentRow.Cells["ClearCost"].Value.ToString();
            this.txtClearIncome.Text = this.dataGridView1.CurrentRow.Cells["ClearIncome"].Value.ToString();
            this.txtReduce_Sum.Text = this.dataGridView1.CurrentRow.Cells["Reduce_Sum"].Value.ToString();
            this.txtWhy.Text = this.dataGridView1.CurrentRow.Cells["Why"].Value.ToString();
            this.comMode.Text = this.dataGridView1.CurrentRow.Cells["Mode"].Value.ToString();
            this.comName.Text = this.dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();
            this.TimeReduce_date.Text = this.dataGridView1.CurrentRow.Cells["Reduce_date"].Value.ToString();
            if (this.txtF_proID.Text == "")
            {
                this.btn.Text = "添加";
            }
            else
            {
                this.btn.Text = "修改";
            }
        }
        /// <summary>
        /// 修改或保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            cilck++;
            if (btn.Text == "添加")
            {
                this.txtF_proID.ReadOnly = false; 
                if (cilck==2)
                {
                    iffolat();
                    if (iffigure == true)
                    {
                        NewFolder1.ReduceGoods reduceGoods = new NewFolder1.ReduceGoods();
                        reduceGoods.F_proID = this.txtF_proID.Text;
                        reduceGoods.Reduce_Sum = Convert.ToInt32(this.txtReduce_Sum.Text);
                        reduceGoods.Mode = this.comMode.Text;
                        reduceGoods.Reduce_date =Convert.ToString(this.TimeReduce_date.Value);
                        reduceGoods.Why = this.txtWhy.Text;
                        reduceGoods.ClearIncome = Convert.ToSingle(this.txtClearIncome.Text);
                        reduceGoods.ClearCost = Convert.ToSingle(this.txtClearCost.Text);
                        reduceGoods.CustomerID = Convert.ToInt32(this.comName.SelectedValue);
                        reduceGoods.Detail = this.txtDetail.Text;
                        if (reduceGoods.Add())
                        {
                            MessageBox.Show("添加成功!");
                            this.txtF_proID.Text = "";
                            this.txtDetail.Text = "";
                            this.txtClearCost.Text = "";
                            this.txtClearIncome.Text = "";
                            this.txtReduce_Sum.Text = "";
                            this.txtWhy.Text = "";
                            this.comMode.Text = "";
                            this.TimeReduce_date.Text = "";
                            dataLoad();
                            cilck = 0;
                        }
                        else
                        {
                            MessageBox.Show("添加失败!");                           
                            cilck = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("请重新输入数值!");
                    }
                }
            }
            else
            {
                if (cilck == 1)
                {
                    iffolat();
                    if (iffigure == true)
                    {
                        NewFolder1.ReduceGoods reduceGoods = new NewFolder1.ReduceGoods();
                        reduceGoods.ReduceGoodsID =Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["ReduceGoodsID"].Value.ToString());
                        reduceGoods.F_proID = this.txtF_proID.Text;
                        reduceGoods.Reduce_Sum = Convert.ToInt32(this.txtReduce_Sum.Text);
                        reduceGoods.Mode = this.comMode.Text;
                        reduceGoods.Reduce_date = Convert.ToString(this.TimeReduce_date.Value);
                        reduceGoods.Why = this.txtWhy.Text;
                        reduceGoods.ClearIncome = Convert.ToSingle(this.txtClearIncome.Text);
                        reduceGoods.ClearCost = Convert.ToSingle(this.txtClearCost.Text);
                        reduceGoods.CustomerID = Convert.ToInt32(this.comName.SelectedValue);
                        reduceGoods.Detail = this.txtDetail.Text;
                        if (reduceGoods.Update())
                        {
                            MessageBox.Show("修改成功!");
                            this.txtF_proID.Text = "";
                            this.txtDetail.Text = "";
                            this.txtClearCost.Text = "";
                            this.txtClearIncome.Text = "";
                            this.txtReduce_Sum.Text = "";
                            this.txtWhy.Text = "";
                            this.comMode.Text = "";
                            this.TimeReduce_date.Text = "";
                            dataLoad();
                            cilck = 0;
                        }
                        else
                        {
                            MessageBox.Show("修改失败!");
                            cilck = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("请重新输入数值!");
                    }
                }
            }
        }
        public bool iffigure = false;
        /// <summary>
        /// 判断数值
        /// </summary>
        public void iffolat()
        {
            if (this.txtReduce_Sum.Text == "" || this.txtClearIncome.Text == "" || this.txtClearCost.Text == "")
            {
                MessageBox.Show("不能为空!");
                cilck--;
            } else
            {
                float num = 0;
                int sum = 0;
                bool i = false;
                if (int.TryParse(txtReduce_Sum.Text, out sum))
                {
                    i = true;
                }
                else
                {
                    MessageBox.Show("请输入正确的值!");
                    i = false;
                }
                if (float.TryParse(txtClearIncome.Text, out num))
                {
                    i = true;
                }
                else
                {
                    MessageBox.Show("请输入正确的值!");
                    i = false;
                }
                if (float.TryParse(txtClearCost.Text, out num))
                {
                    i = true;
                }
                else
                {
                    MessageBox.Show("请输入正确的值!");
                    i = false;
                }
                if (i == true) 
                {
                    iffigure = true;
                }
            }
        }
    }
}
