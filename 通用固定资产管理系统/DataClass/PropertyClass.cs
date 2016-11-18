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
    /// 资产类型表
    /// </summary>
    class PropertyClass : IDAO
    {
        private string classID;
        private string classNAme;
        /// <summary>
        /// 资产类型编号
        /// </summary>
        public string ClassID
        {
            get
            {
                return classID;
            }

            set
            {
                classID = value;
            }
        }
        /// <summary>
        /// 资产类型名称
        /// </summary>
        public string ClassNAme
        {
            get
            {
                return classNAme;
            }

            set
            {
                classNAme = value;
            }
        }

        public bool Add()
        {
            string StrSql = string.Format("INSERT INTO PropertyClass VALUES('{0}','{1}')", this.ClassID, this.ClassNAme);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            string StrSql = string.Format("DELETE FROM PropertyClass where ClassID='{0}'", id);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = "select * from PropertyClass";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            string StrSql = string.Format("UPDATE PropertyClass SET CalssName = '{0}' where ClassID='{1}'", this.ClassNAme, this.ClassID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public DataTable SetPro(string id)
        {
            string StrSql = @"select PropertyClass.CalssName, GoodsName,ReduceGoods.ID,ReduceGoods.F_proID,Reduce_Sum,Mode,Reduce_date,Why,ClearIncome,ClearCost ,CustomerName,ReduceGoods.Detail from ReduceGoods,Goods,Customer,PropertyClass where ReduceGoods.F_proID=Goods.F_proID and Customer.CustomerID=reduceGoods.CustomerID and PropertyClass.ClassID=Goods.ClassID";
            DataTable dt = SqlDBHelper.GetDataTable(StrSql);
            foreach (DataRow item in dt.Rows)
            {
                if (id == item["CalssName"].ToString())
                {
                    StrSql = " select GoodsName,ReduceGoods.ID,ReduceGoods.F_proID,Reduce_Sum,Mode,Reduce_date,Why,ClearIncome,ClearCost ,CustomerName, PropertyClass.CalssName,ReduceGoods.Detail from ReduceGoods,Goods,Customer,PropertyClass where ReduceGoods.F_proID=Goods.F_proID and Customer.CustomerID=reduceGoods.CustomerID and PropertyClass.ClassID=Goods.ClassID and CalssName ='" + id + "'";
                }
                else
                {
                    StrSql = " select  GoodsName,ReduceGoods.ID,ReduceGoods.F_proID,Reduce_Sum,Mode,Reduce_date,Why,ClearIncome,ClearCost ,CustomerName,PropertyClass.CalssName,ReduceGoods.Detail from ReduceGoods,Goods,Customer,PropertyClass where ReduceGoods.F_proID=Goods.F_proID and Customer.CustomerID=reduceGoods.CustomerID and PropertyClass.ClassID=Goods.ClassID and GoodsName ='" + id + "'";
                }
            }
            
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public DataTable dataLoad()
        {
            string StrSql = " select GoodsName,ReduceGoods.ID,ReduceGoods.F_proID,Reduce_Sum,Mode,Reduce_date,Why,ClearIncome,ClearCost ,CustomerName,ReduceGoods.Detail from ReduceGoods,Goods,Customer where ReduceGoods.F_proID=Goods.F_proID and Customer.CustomerID=reduceGoods.CustomerID";
            return SqlDBHelper.GetDataTable(StrSql);

        }
    }
}
