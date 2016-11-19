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
    /// 固定资产借还表
    /// </summary>
    class Borrow:IDAO
    {
        private int borrowID;
        private string  f_proID;
        private int borrow_sum;
        private string borrow_Date;
        private string predict_date;
        private string nowDate;
        private float predict_money;
        private float money;
        private string company;
        private int customerID;
        private string detail;

        public int BorrowID
        {
            get
            {
                return borrowID;
            }

            set
            {
                borrowID = value;
            }
        }

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

        public int Borrow_sum
        {
            get
            {
                return borrow_sum;
            }

            set
            {
                borrow_sum = value;
            }
        }

        public string Borrow_Date
        {
            get
            {
                return borrow_Date;
            }

            set
            {
                borrow_Date = value;
            }
        }

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

        public float Predict_money
        {
            get
            {
                return predict_money;
            }

            set
            {
                predict_money = value;
            }
        }

        public float Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }

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
            string StrSql = string.Format(@"INSERT INTO borrow(F_proID,Borrow_sum,Borrow_Date,Predict_date,NowDate,Predict_money,Money,Company,CustomerID,Detail)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
, this.F_proID,this.Borrow_sum,this.Borrow_Date,
this.Predict_date,this.NowDate,this.Predict_money,this.Money,this.Company,this.CustomerID,this.Detail);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Update()
        {
            string StrSql = string.Format(@"UPDATE [dbo].[Borrow]   SET [F_proID] = '{0}',[Borrow_sum] = '{1}',[Borrow_Date] = '{2}',[Predict_date] = '{3}',[NowDate] = '{4}'
,[Predict_money] = '{5}',[Money] = '{6}',[Company] = '{7}',[CustomerID] = '{8}',[Detail] = '{9}' WHERE ID='{10}'",
this.F_proID,this.Borrow_sum,this.Borrow_Date,this.Predict_date,this.NowDate,this.Predict_money,this.Money,this.Company,this.CustomerID,this.Detail,this.BorrowID);
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
    }
}
