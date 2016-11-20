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
        NewFolder1.Service service = new NewFolder1.Service();
        public int i = 0;
        /// <summary>
        /// dataview的单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            DataLoad();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        /// <summary>
        /// 单机节点事件
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
            dataGridView1.DataSource = service.ServiceLoad(e.Node.Text);
        }
        /// <summary>
        /// 加载DATA
        /// </summary>
        public void DataLoad()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = service.SelectListByWhere("");
        }
        /// <summary>
        /// 点击送修
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                btnColes();
            }           
            i++;            
            if(i==2)
            {
                MessageBox.Show(this.Service_sum.Text);
                service.F_proID = this.F_proID.Text;
                service.Service_sum = Convert.ToInt32(this.Service_sum.Text);
                service.Service_Date = this.Service_Date.Value.ToString();
                service.Predict_date = this.Predict_date.Value.ToString();
                service.NowDate = null;
                service.Cost = Convert.ToSingle(this.Cost.Text);
                if (this.NowCost.Text == "")
                {
                    this.NowCost.Text = "0";
                }
                service.NowCost = Convert.ToSingle(this.NowCost.Text);
                service.Company = this.Company.Text;
                service.Breakdown = this.Breakdown.Text;
                service.Service_txt = this.Service_txt.Text;
                service.Detail = this.Detail.Text;
                if (service.Add())
                {
                    MessageBox.Show("添加送修记录成功!");
                    btnColes();
                    DataLoad();
                    i = 0;
                }
            }            
            
        }
        /// <summary>
        /// 清空文本框
        /// </summary>
        public void btnColes()
        {
            this.Service_sum.Text = "";
            this.Cost.Text = "";
            this.Company.Text = "";
            this.NowCost.Text = "";
            this.Breakdown.Text = "";
            this.Detail.Text = "";
        }
        /// <summary>
        /// dataview的单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentRow.Cells["ID"].Value.ToString() != "")
            {
                this.btnUpdate.Enabled = true;
                this.F_proID.Text = this.dataGridView1.CurrentRow.Cells["F_proID"].Value.ToString();
                this.Service_sum.Text = this.dataGridView1.CurrentRow.Cells["Service_sum"].Value.ToString();
                this.NowDate.Text = this.dataGridView1.CurrentRow.Cells["NowDate"].Value.ToString();
                this.Predict_date.Text = this.dataGridView1.CurrentRow.Cells["Predict_date"].Value.ToString();
                this.Service_Date.Text = this.dataGridView1.CurrentRow.Cells["Service_Date"].Value.ToString();
                this.Cost.Text = this.dataGridView1.CurrentRow.Cells["Cost"].Value.ToString();
                this.NowCost.Text = this.dataGridView1.CurrentRow.Cells["NowCost"].Value.ToString();
                this.Company.Text = this.dataGridView1.CurrentRow.Cells["Company"].Value.ToString();
                this.Breakdown.Text = this.dataGridView1.CurrentRow.Cells["Breakdown"].Value.ToString();
                this.Service_txt.Text = this.dataGridView1.CurrentRow.Cells["Service_txt"].Value.ToString();
                this.Detail.Text = this.dataGridView1.CurrentRow.Cells["Detail"].Value.ToString();
            }
            else
            {
                btnColes();
                this.btnUpdate.Enabled = false;
            }
        }
    }
}
