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
    public partial class ItemDetails : Form
    {
        public ItemDetails()
        {
            InitializeComponent();
        }
        NewFolder1.Goods goods = new NewFolder1.Goods();
        NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
        NewFolder1.Repertory repertory = new NewFolder1.Repertory();
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemDetails_Load(object sender, EventArgs e)
        {
            listGoodsLoad();
        }
        /// <summary>
        /// 根据分类加载项
        /// </summary>
        public void listGoodsLoad()
        {
            tvw.Nodes.Clear();
            if (this.rdbGoods.Checked == true)
            {
                goods.SelectListByWhere("");
                propertyClass.SelectListByWhere("");
                foreach (DataRow pro in propertyClass.SelectListByWhere("").Rows)
                {
                    TreeNode node = new TreeNode(pro["CalssName"].ToString());
                    node.Tag = pro["ClassID"].ToString();
                    this.tvw.Nodes.Add(node);

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
            if (this.radioButton2.Checked == true)
            {
                goods.SelectListByWhere("");
                repertory.SelectListByWhere("");
                foreach (DataRow pro in repertory.SelectListByWhere("").Rows)
                {
                    TreeNode node = new TreeNode(pro["RepName"].ToString());
                    node.Tag = pro["RepID"].ToString();
                    this.tvw.Nodes.Add(node);

                    //遍历所有资产
                    foreach (DataRow goodsNode in goods.SelectListByWhere("").Rows)
                    {
                        if (pro["RepID"].ToString() == goodsNode["RepID"].ToString())
                        {
                            TreeNode subNode = new TreeNode(goodsNode["GoodsName"].ToString());
                            node.Nodes.Add(subNode);
                        }
                    }
                }
            }
        }

        private void rdbGoods_Click(object sender, EventArgs e)
        {
            this.rdbGoods.Checked = true;
            listGoodsLoad();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            this.radioButton2.Checked = true;
            listGoodsLoad();
        }
        /// <summary>
        /// 单击节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvw_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NewFolder1.Goods goods = new NewFolder1.Goods();
            foreach (DataRow item in goods.ItemLoad(e.Node.Text).Rows)
            {
                this.F_proID.Text = item["F_proID"].ToString();
                this.GoodsID.Text = item["GoodsID"].ToString();
                this.GoodsName.Text = item["GoodsName"].ToString();
                this.SumOld.Text = item["SumOld"].ToString();
                this.ClassID.Text = item["CalssName"].ToString();
                this.OldInfo.Text = item["OldInfo"].ToString();
                this.Type.Text = item["Type"].ToString();
                this.MakeName.Text = item["MakeName"].ToString();
                this.OldMonth.Text = item["OldMonth"].ToString();
                this.IntoDate.Text = item["IntoDate"].ToString();
                this.RepID.Text = item["RepName"].ToString();
                this.Sub_Month.Text = item["Sub_Month"].ToString();
                this.DepID.Text = item["DepName"].ToString();
                this.State.Text = item["State"].ToString();
                this.Month_Money.Text = item["Month_Money"].ToString();
                this.AddType.Text = item["AddType"].ToString();
                this.Quantity.Text = item["Quantity"].ToString();
                this.JingCanZhi.Text = item["JingCanZhi"].ToString();
                this.OrderUnit.Text = item["OrderUnit"].ToString();
                this.Price.Text = item["Price"].ToString();
                this.Detail.Text = item["Detail"].ToString();
                this.Money.Text = item["Money"].ToString();
                this.Pro_value.Text = item["Pro_value"].ToString();
            }

        }
    }
}

