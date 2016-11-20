using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 第八章_接口;
using CSharpProjectDemo.DAL;
using System.Data;
using System.Threading.Tasks;

namespace 通用固定资产管理系统.NewFolder1
{
    /// <summary>
    /// 固定资产维修表
    /// </summary>
    class Service : IDAO
    {
        private int serviceID;
        private string f_proID;
        private int service_sum;
        private string service_Date;
        private string predict_date;
        private string nowDate;
        private float cost;
        private float nowCost;
        private string company;
        private string breakdown;
        private string service_txt;
        private string detail;
        /// <summary>
        /// 固定资产维修表主键ID
        /// </summary>
        public int ServiceID
        {
            get
            {
                return serviceID;
            }

            set
            {
                serviceID = value;
            }
        }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string F_proID
        {
            get
            {
                return f_proID;
            }

            set
            {
                f_proID = value;
            }
        }
        /// <summary>
        /// 送修数量
        /// </summary>
        public int Service_sum
        {
            get
            {
                return service_sum;
            }

            set
            {
                service_sum = value;
            }
        }
        /// <summary>
        /// 送修日期
        /// </summary>
        public string Service_Date
        {
            get
            {
                return service_Date;
            }

            set
            {
                service_Date = value;
            }
        }
        /// <summary>
        /// 预期完修日期
        /// </summary>
        public string Predict_date
        {
            get
            {
                return predict_date;
            }

            set
            {
                predict_date = value;
            }
        }
        /// <summary>
        /// 实际完修日期
        /// </summary>
        public string NowDate
        {
            get
            {
                return nowDate;
            }

            set
            {
                nowDate = value;
            }
        }
        /// <summary>
        /// 预期修理费用
        /// </summary>
        public float Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }
        /// <summary>
        /// 实际修理费用
        /// </summary>
        public float NowCost
        {
            get
            {
                return nowCost;
            }

            set
            {
                nowCost = value;
            }
        }
        /// <summary>
        /// 修理公司
        /// </summary>
        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }
        /// <summary>
        /// 故障原因
        /// </summary>
        public string Breakdown
        {
            get
            {
                return breakdown;
            }

            set
            {
                breakdown = value;
            }
        }
        /// <summary>
        /// 修理情况
        /// </summary>
        public string Service_txt
        {
            get
            {
                return service_txt;
            }

            set
            {
                service_txt = value;
            }
        }
        /// <summary>
        /// 说明
        /// </summary>
        public string Detail
        {
            get
            {
                return detail;
            }

            set
            {
                detail = value;
            }
        }

        public bool Add()
        {
            string StrSql = string.Format(@"INSERT INTO Service ([F_proID],[Service_sum],[Service_Date],[Predict_date],[NowDate],[Cost],[NowCost],[Company]
,[Breakdown],[Service_txt],[Detail])VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
this.F_proID, this.Service_sum, this.Service_Date, this.Predict_date, this.NowDate, this.Cost, this.NowCost, this.Company,
this.Breakdown, this.Service_txt, this.Detail);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = "select * from Service";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }
        public DataTable ServiceLoad(string id)
        {
            string StrSql = @"select ID,GoodsName,CalssName,Service_sum,Service_Date,Predict_date,NowDate,Cost,NowCost,Company,Breakdown,Service_txt,Service.Detail
 from Service,Goods,PropertyClass where Goods.F_proID=Service.F_proID and PropertyClass.ClassID=Goods.ClassID";
            DataTable dt = SqlDBHelper.GetDataTable(StrSql);
            foreach (DataRow item in dt.Rows)
            {
                if (id == item["CalssName"].ToString())
                {
                    StrSql = @"select ID,GoodsName,CalssName,Service_sum,Service_Date,Predict_date,NowDate,Cost,NowCost,Company,Breakdown,Service_txt,Service.Detail
 from Service, Goods, PropertyClass where Goods.F_proID = Service.F_proID and PropertyClass.ClassID = Goods.ClassID and CalssName='" + id + "'";
                }
                else
                {
                    StrSql = @"select ID,GoodsName,CalssName,Service_sum,Service_Date,Predict_date,NowDate,Cost,NowCost,Company,Breakdown,Service_txt,Service.Detail
 from Service, Goods, PropertyClass where Goods.F_proID = Service.F_proID and PropertyClass.ClassID = Goods.ClassID and GoodsName='" + id + "'";
                }
            }
            return SqlDBHelper.GetDataTable(StrSql);
        }
    }
}
