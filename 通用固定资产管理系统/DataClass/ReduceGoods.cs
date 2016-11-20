using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 第八章_接口;
using CSharpProjectDemo.DAL;
using System.Data;

namespace 通用固定资产管理系统.NewFolder1
{
    /// <summary>
    /// 固定资产减少表
    /// </summary>
    class ReduceGoods:IDAO
    {
        private int reduceGoodsID;
        private string f_proID;
        private int reduce_Sum;
        private string mode;
        private string reduce_date;
        private string why;
        private float clearIncome;
        private float clearCost;
        private int customerID;
        private string detail;
        /// <summary>
        /// 固定资产减少表主键ID
        /// </summary>
        public int ReduceGoodsID
        {
            get
            {
                return reduceGoodsID;
            }

            set
            {
                reduceGoodsID = value;
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
        /// 减少数量
        /// </summary>
        public int Reduce_Sum
        {
            get
            {
                return reduce_Sum;
            }

            set
            {
                reduce_Sum = value;
            }
        }
        /// <summary>
        /// 减少方式
        /// </summary>
        public string Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }
        /// <summary>
        /// 减少日期
        /// </summary>
        public string Reduce_date
        {
            get
            {
                return reduce_date;
            }

            set
            {
                reduce_date = value;
            }
        }
        /// <summary>
        /// 减少原因
        /// </summary>
        public string Why
        {
            get
            {
                return why;
            }

            set
            {
                why = value;
            }
        }
        /// <summary>
        /// 清理输入
        /// </summary>
        public float ClearIncome
        {
            get
            {
                return clearIncome;
            }

            set
            {
                clearIncome = value;
            }
        }
        /// <summary>
        /// 清理费用
        /// </summary>
        public float ClearCost
        {
            get
            {
                return clearCost;
            }

            set
            {
                clearCost = value;
            }
        }
        /// <summary>
        /// 经办人
        /// </summary>
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
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
            string StrSql = string.Format(@"INSERT INTO reduceGoods(F_proID,Reduce_Sum,Mode,Reduce_date,Why,ClearIncome,ClearCost,CustomerID,Detail)VALUES
           ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}')",this.F_proID,this.Reduce_Sum,this.Mode,this.Reduce_date,this.Why,this.ClearIncome,this.ClearCost,this.CustomerID,this.Detail);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Update()
        {
            string StrSql = string.Format("UPDATE reduceGoods   SET Reduce_Sum = '{0}' ,Mode = '{1}' ,Reduce_date = '{2}' ,Why= '{3}' ,ClearIncome = '{4}' ,ClearCost = '{5}' ,CustomerID = '{6}' ,Detail = '{7}'  WHERE  ID ='{8}'", this.Reduce_Sum, this.Mode, this.Reduce_date, this.Why, this.ClearIncome, this.ClearCost, this.CustomerID, this.Detail,this.ReduceGoodsID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            throw new NotImplementedException();
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }
        public DataTable dateCilct(string date, string deta)
        {
            string StrSql = " select * from ReduceGoods where NowDate>'" + date + "' and NowDate<'" + deta + "'";
            return SqlDBHelper.GetDataTable(StrSql);
        }
    }
}
