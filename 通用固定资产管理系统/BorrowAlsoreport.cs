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
    public partial class BorrowAlsoreport : Form
    {
        public BorrowAlsoreport()
        {
            InitializeComponent();
        }

        private void BorrowAlsoreport_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        /// <summary>
        /// 加载报表事件
        /// </summary>
        public void dataLoad()
        {
            NewFolder1.Borrow borrow = new NewFolder1.Borrow();
          this.dataGridView1.DataSource= borrow.SelectListByWhere("");
        }
        /// <summary>
        /// 搜索事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string tiem1 = this.dateTimePicker1.Value.ToString();
            string tiem2 = this.dateTimePicker2.Value.ToString();
            DateTime dt1 = Convert.ToDateTime(tiem1);
            DateTime dt2 = Convert.ToDateTime(tiem2);
            if (DateTime.Compare(dt1, dt2) > 0)
            {
                NewFolder1.Borrow borrow = new NewFolder1.Borrow();
                this.dataGridView1.DataSource = borrow.dateCilct(this.dateTimePicker2.Value.ToString(), this.dateTimePicker1.Value.ToString());
            }
            else
            {
                NewFolder1.Borrow borrow = new NewFolder1.Borrow();
                this.dataGridView1.DataSource = borrow.dateCilct(this.dateTimePicker1.Value.ToString(), this.dateTimePicker2.Value.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewFolder1.Borrow borrow = new NewFolder1.Borrow();
            this.dataGridView1.DataSource = borrow.SelectListByWhere("");
        }
    }
}
