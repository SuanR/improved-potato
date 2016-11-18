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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }
        NewFolder1.PropertyClass propertyClass = new NewFolder1.PropertyClass();
        NewFolder1.Goods goods = new NewFolder1.Goods();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormService_Load(object sender, EventArgs e)
        {
            treeLoad();
        }
        /// <summary>
        /// 遍历treelist列表
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
    }
}
