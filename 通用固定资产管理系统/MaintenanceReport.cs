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
    public partial class MaintenanceReport : Form
    {
        public MaintenanceReport()
        {
            InitializeComponent();
        }

        private void MaintenanceReport_Load(object sender, EventArgs e)
        {
            NewFolder1.Service service = new NewFolder1.Service();
           this.dataGridView1.DataSource= service.SelectListByWhere("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tiem1 = this.dateTimePicker1.Value.ToString();
            string tiem2 = this.dateTimePicker2.Value.ToString();
            DateTime dt1 = Convert.ToDateTime(tiem1);
            DateTime dt2 = Convert.ToDateTime(tiem2);
            if (DateTime.Compare(dt1, dt2) > 0)
            {
                NewFolder1.Service service = new NewFolder1.Service();
                this.dataGridView1.DataSource = service.dateCilct(this.dateTimePicker2.Value.ToString(), this.dateTimePicker1.Value.ToString());
            }
            else
            {
                NewFolder1.Service service = new NewFolder1.Service();
                this.dataGridView1.DataSource = service.dateCilct(this.dateTimePicker1.Value.ToString(), this.dateTimePicker2.Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewFolder1.Service service = new NewFolder1.Service();
            this.dataGridView1.DataSource = service.SelectListByWhere("");
        }
    }
}
