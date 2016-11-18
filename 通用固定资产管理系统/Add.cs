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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        NewFolder1.Goods goods = new NewFolder1.Goods();
        public string ascertain = "无";
        public bool ifNull = false;
        public bool ifFolat = false;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Load(object sender, EventArgs e)
        {
            listLoad();
            this.DataGoodsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comLoad();
        }
        /// <summary>
        /// 加载下拉列表
        /// </summary>
        public void comLoad()
        {
            DataTable dt = goods.comDepIDLoad();
            comDepID.DataSource = dt;//绑定数据库
            comDepID.ValueMember = "DepID";//显示掩藏的值
            comDepID.DisplayMember = "DepName";//最后加载出来的列
            DataTable dtClassID = goods.comClassID();
            comClassID.DataSource = dtClassID;//绑定数据库
            comClassID.ValueMember = "ClassID";//显示掩藏的值
            comClassID.DisplayMember = "CalssName";//最后加载出来的列
            DataTable dtcomRepID = goods.comRepID();
            comRepID.DataSource = dtcomRepID;//绑定数据库
            comRepID.ValueMember = "RepID";//显示掩藏的值
            comRepID.DisplayMember = "RepName";//最后加载出来的列
        }
        /// <summary>
        /// 窗体加载时
        /// </summary>
        public void listLoad()
        {
            this.DataGoodsTable.DataSource = "";
            DataTable dt = goods.SelectListByWhere("");
            this.DataGoodsTable.DataSource = dt;
        }
        /// <summary>
        /// 点击某一行显示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGoodsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtAddType.Text = this.DataGoodsTable.CurrentRow.Cells["AddType"].Value.ToString();
            this.txtF_proID.Text = this.DataGoodsTable.CurrentRow.Cells["F_proID"].Value.ToString();
            this.txtDetail.Text = this.DataGoodsTable.CurrentRow.Cells["Detail"].Value.ToString();
            this.txtGoodsID.Text = this.DataGoodsTable.CurrentRow.Cells["GoodsID"].Value.ToString();
            this.txtGoodsName.Text = this.DataGoodsTable.CurrentRow.Cells["GoodsName"].Value.ToString();
            this.txtIntoDate.Text = this.DataGoodsTable.CurrentRow.Cells["IntoDate"].Value.ToString();
            this.txtJingCanZhi.Text = this.DataGoodsTable.CurrentRow.Cells["JingCanZhi"].Value.ToString();
            this.txtMakName.Text = this.DataGoodsTable.CurrentRow.Cells["MakeName"].Value.ToString();
            this.txtMoney.Text = this.DataGoodsTable.CurrentRow.Cells["Money"].Value.ToString();
            this.txtMonth_Money.Text = this.DataGoodsTable.CurrentRow.Cells["Month_Money"].Value.ToString();
            this.txtOldMonth.Text = this.DataGoodsTable.CurrentRow.Cells["OldMonth"].Value.ToString();
            this.txtOrderUnit.Text = this.DataGoodsTable.CurrentRow.Cells["OrderUnit"].Value.ToString();
            this.txtPrice.Text = this.DataGoodsTable.CurrentRow.Cells["Price"].Value.ToString();
            this.txtPro_value.Text = this.DataGoodsTable.CurrentRow.Cells["Pro_value"].Value.ToString();
            this.txtQuantity.Text = this.DataGoodsTable.CurrentRow.Cells["Quantity"].Value.ToString();
            this.txtState.Text = this.DataGoodsTable.CurrentRow.Cells["State"].Value.ToString();
            this.txtSub_Month.Text = this.DataGoodsTable.CurrentRow.Cells["Sub_Month"].Value.ToString();
            this.txtSumOld.Text = this.DataGoodsTable.CurrentRow.Cells["SumOld"].Value.ToString();
            this.txtType.Text = this.DataGoodsTable.CurrentRow.Cells["Type"].Value.ToString();
            this.comDepID.SelectedValue = this.DataGoodsTable.CurrentRow.Cells["DepID"].Value.ToString();
            this.comClassID.SelectedValue = this.DataGoodsTable.CurrentRow.Cells["ClassID"].Value.ToString();
            this.comRepID.SelectedValue = this.DataGoodsTable.CurrentRow.Cells["RepID"].Value.ToString();

            if (this.txtGoodsID.Text == "")
            {
                this.btnUpdate.Enabled = false;
                this.btnAdd.Enabled = true;
            }
            else
            {
                this.btnUpdate.Enabled = true;
            }
        }    
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {

            switch (ascertain)
            {
                case "无":
                    MessageBox.Show("请选择添加或修改!!!");
                    break;
                case "添加":
                    nullIf();
                    if (ifNull == true)
                    {
                        if (goods.Add())
                        {
                            MessageBox.Show("添加成功!");
                            listLoad();
                            txtnull();
                            ifNull = false;
                        }
                        else
                        {
                            MessageBox.Show("添加失败!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加有误!");
                    }
                    break;
                case "修改":
                    nullIf();
                    if (ifNull == true)
                    {
                        if (goods.Update())
                        {
                            MessageBox.Show("修改成功!");
                            listLoad();
                            txtnull();
                            ifNull = false;
                        }
                        else
                        {
                            MessageBox.Show("修改失败!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("修改信息有误!");
                    }
                    break;
            }
        }
        /// <summary>
        /// 添加点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ascertain = "添加";
            txtnull();
        }
        /// <summary>
        /// txt文本框为空事件
        /// </summary>
        public void txtnull()
        {
            this.txtAddType.Text = "";
            this.txtF_proID.Text = "";            
            this.txtDetail.Text = "";
            this.txtGoodsID.Text = "";
            this.txtGoodsName.Text = "";
            this.txtIntoDate.Text = "";
            this.txtJingCanZhi.Text = "";
            this.txtMakName.Text = "";
            this.txtMoney.Text = "";
            this.txtMonth_Money.Text = "";
            this.txtOldMonth.Text = "";
            this.txtOrderUnit.Text = "";
            this.txtPrice.Text = "";
            this.txtPro_value.Text = "";
            this.txtQuantity.Text = "";
            this.txtState.Text = "";
            this.txtSub_Month.Text = "";
            this.txtSumOld.Text = "";
            this.txtType.Text = "";

        }
        /// <summary>
        /// 修改点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ascertain = "修改";
        }
        /// <summary>
        /// 判断是否为空
        /// </summary>
        public void nullIf()
        {
            if (this.txtF_proID.Text == "")
            {
                MessageBox.Show("资产编号不能为空");
            }
            else
            {
                if (this.txtGoodsName.Text == "")
                {
                    MessageBox.Show("资产名称不能为空");
                }
                else
                {
                    if (this.txtState.Text == "")
                    {
                        MessageBox.Show("使用状态不能为空");
                    }
                    else
                    {
                        if (this.txtQuantity.Text == "")
                        {
                            MessageBox.Show("数量不能为空");
                        }
                        else
                        {
                            if (this.txtPrice.Text == "")
                            {
                                MessageBox.Show("单价不能为空");
                            }
                            else
                            {
                                if (this.txtMoney.Text == "")
                                {
                                    MessageBox.Show("金额不能为空");
                                }
                                else
                                {
                                    if (this.txtOrderUnit.Text == "")
                                    {
                                        MessageBox.Show("计量单位不能为空");
                                    }
                                    else
                                    {
                                        iffolat();
                                        if (ifFolat == true)
                                        {
                                            goods.F_proID = this.txtF_proID.Text;
                                            goods.GoodsID = this.txtGoodsID.Text;
                                            goods.GoodsName = this.txtGoodsName.Text;
                                            goods.SumOld = Convert.ToSingle(this.txtSumOld.Text);
                                            goods.ClassID = this.comClassID.SelectedValue.ToString();
                                            goods.OldInfo = this.comOldInfo.Text;
                                            goods.Type = this.txtType.Text;
                                            goods.MakeName = this.txtMakName.Text;
                                            goods.OldMonth = Convert.ToInt32(this.txtOldMonth.Text);
                                            goods.IntoDate = txtIntoDate.Value.ToString();
                                            goods.RepID = this.comRepID.SelectedValue.ToString();
                                            goods.Sub_Month = Convert.ToInt32(this.txtSub_Month.Text);
                                            goods.DepID = this.comDepID.SelectedValue.ToString();
                                            goods.State = this.txtState.Text;
                                            goods.Month_Money = Convert.ToSingle(this.txtMonth_Money.Text);
                                            goods.AddType = this.txtAddType.Text;
                                            goods.Quantity = Convert.ToInt32(this.txtQuantity.Text);
                                            goods.JingCanZhi = Convert.ToSingle(this.txtJingCanZhi.Text);
                                            goods.OrderUnit = this.txtOrderUnit.Text;
                                            goods.Price = Convert.ToSingle(this.txtPrice.Text);
                                            goods.Detail = this.txtDetail.Text;
                                            goods.Money = Convert.ToSingle(this.txtMoney.Text);
                                            goods.Pro_value = Convert.ToSingle(this.txtPro_value.Text);
                                            ifNull = true;
                                            ifFolat = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("请输入正确的值!");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 判断浮点型
        /// </summary>
        public void iffolat()
        {
            float num = 0;
            int sum = 0;
            bool i = false;
            if (float.TryParse(txtPro_value.Text, out num) || txtPro_value.Text == "")
            {
                i = true;
                if(txtPro_value.Text == "")
                {
                    txtPro_value.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (float.TryParse(txtMoney.Text, out num) || txtMoney.Text == "")
            {
                i = true;
                if (txtMoney.Text == "")
                {
                    txtMoney.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (float.TryParse(txtJingCanZhi.Text, out num) || txtJingCanZhi.Text == "")
            {
                i = true;
                if (txtJingCanZhi.Text == "")
                {
                    txtJingCanZhi.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (float.TryParse(txtSumOld.Text, out num) || txtSumOld.Text == "")
            {
                if (txtSumOld.Text == "")
                {
                    txtSumOld.Text = "0";
                }
                i = true;
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (float.TryParse(txtMonth_Money.Text, out num) || txtMonth_Money.Text == "")
            {
                if (txtMonth_Money.Text == "")
                {
                    txtMonth_Money.Text = "0";
                }
                i = true;
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (float.TryParse(txtPrice.Text, out num) || txtPrice.Text == "")
            {
                if (txtPrice.Text == "")
                {
                    txtPrice.Text = "0";
                }
                i = true;
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (int.TryParse(txtOldMonth.Text, out sum) || txtOldMonth.Text == "")
            {
                if (txtOldMonth.Text == "")
                {
                    txtOldMonth.Text = "0";
                }
                i = true;
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }            
            if (int.TryParse(txtSub_Month.Text, out sum) || txtSub_Month.Text == "")
            {
                if (txtSub_Month.Text == "")
                {
                    txtSub_Month.Text = "0";
                }
                i = true;
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (int.TryParse(txtQuantity.Text, out sum) || txtQuantity.Text == "")
            {
                if (txtQuantity.Text == "")
                {
                    txtQuantity.Text = "0";
                }
                i = true;
            }
            else
            {
                MessageBox.Show("请输入正确的值!");
                i = false;
            }
            if (i == true)
            {
                ifFolat = true;
            }
            else
            {
                ifFolat = false;
            }
        }
    }
}
