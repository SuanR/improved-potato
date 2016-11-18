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
    /// 固定资产信息表
    /// </summary>
    class Goods : IDAO
    {

        private string f_proID;
        private string goodsID;
        private string goodsName;
        private float sumOld;
        private string classID;
        private string oldInfo;
        private string type;
        private string makeName;
        private int oldMonth;
        private string intoDate;
        private string repID;
        private int sub_Month;
        private string depID;
        private string state;
        private float month_Money;
        private string addType;
        private int quantity;
        private float jingCanZhi;
        private string orderUnit;
        private float price;
        private string detail;
        private float money;
        private float pro_value;
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
        /// 自编号
        /// </summary>
        public string GoodsID
        {
            get
            {
                return goodsID;
            }

            set
            {
                goodsID = value;
            }
        }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string GoodsName
        {
            get
            {
                return goodsName;
            }

            set
            {
                goodsName = value;
            }
        }
        /// <summary>
        /// 累计折旧
        /// </summary>
        public float SumOld
        {
            get
            {
                return sumOld;
            }

            set
            {
                sumOld = value;
            }
        }
        /// <summary>
        /// 资产分类
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
        /// 折旧方法
        /// </summary>
        public string OldInfo
        {
            get
            {
                return oldInfo;
            }

            set
            {
                oldInfo = value;
            }
        }
        /// <summary>
        /// 型号
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        /// <summary>
        /// 制造厂家
        /// </summary>
        public string MakeName
        {
            get
            {
                return makeName;
            }

            set
            {
                makeName = value;
            }
        }
        /// <summary>
        /// 折旧月数
        /// </summary>
        public int OldMonth
        {
            get
            {
                return oldMonth;
            }

            set
            {
                oldMonth = value;
            }
        }
        /// <summary>
        /// 出厂日期
        /// </summary>
        public string IntoDate
        {
            get
            {
                return intoDate;
            }

            set
            {
                intoDate = value;
            }
        }
        /// <summary>
        /// 存放仓库
        /// </summary>
        public string RepID
        {
            get
            {
                return repID;
            }

            set
            {
                repID = value;
            }
        }
        /// <summary>
        /// 已提月数
        /// </summary>
        public int Sub_Month
        {
            get
            {
                return sub_Month;
            }

            set
            {
                sub_Month = value;
            }
        }
        /// <summary>
        /// 使用部门
        /// </summary>
        public string DepID
        {
            get
            {
                return depID;
            }

            set
            {
                depID = value;
            }
        }
        /// <summary>
        /// 使用状态
        /// </summary>
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
        /// <summary>
        /// 月度折旧额
        /// </summary>
        public float Month_Money
        {
            get
            {
                return month_Money;
            }

            set
            {
                month_Money = value;
            }
        }
        /// <summary>
        /// 添加方式
        /// </summary>
        public string AddType
        {
            get
            {
                return addType;
            }

            set
            {
                addType = value;
            }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        /// <summary>
        /// 预计净残值
        /// </summary>
        public float JingCanZhi
        {
            get
            {
                return jingCanZhi;
            }

            set
            {
                jingCanZhi = value;
            }
        }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string OrderUnit
        {
            get
            {
                return orderUnit;
            }

            set
            {
                orderUnit = value;
            }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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
        /// <summary>
        /// 金额
        /// </summary>
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
        /// <summary>
        /// 资产原值
        /// </summary>
        public float Pro_value
        {
            get
            {
                return pro_value;
            }

            set
            {
                pro_value = value;
            }
        }

        public bool Add()
        {
            string sqlstr = string.Format("insert  Goods(F_proID,GoodsID	,GoodsName,ClassID,OldInfo,Type,MakeName,OldMonth,IntoDate,RepID,DepID,State,AddType,Quantity,JingCanZhi,OrderUnit,Price,Detail,Money,Pro_value)	select'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}' ,'{13}','{14}','{15}','{16}','{17}','{18}','{19}'",
                this.F_proID, this.GoodsID, this.GoodsName, this.ClassID, this.OldInfo, this.Type, this.MakeName, this.OldMonth, this.IntoDate, this.RepID, DepID, this.State, this.AddType, this.Quantity, this.JingCanZhi, this.OrderUnit, this.Price, this.Detail, this.Money, this.Pro_value);
            return SqlDBHelper.ExecuteNonQuery(sqlstr);
        }

        public bool Update()
        {
            string StrSql = string.Format(@"UPDATE Goods SET[F_proID] = '{0}',[GoodsName] = '{1}',
[ClassID] = '{2}',[Type] = '{3}' ,[MakeName] = '{4}',[OldMonth] = '{5}',[IntoDate] = '{6}',[RepID] = '{7}'
,[DepID] = '{8}',[State] = '{9}',[AddType] = '{10}',[Quantity] = '{11}',[JingCanZhi] = '{12}'
,[OrderUnit] = '{13}',[Price] = '{14}',[Detail] = '{15}',[Money] = '{16}',[Pro_value] = '{17}'
 WHERE GoodsID = '{18}'", this.F_proID, this.GoodsName, this.ClassID, this.Type, this.MakeName, this.OldMonth,
 this.IntoDate, this.RepID, this.DepID, this.State, this.AddType, this.Quantity, this.JingCanZhi, this.OrderUnit
 , this.Price, this.Detail, this.Money, this.Pro_value, this.GoodsID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = "select * from Goods";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 查询部门
        /// </summary>
        /// <returns></returns>
        public DataTable comDepIDLoad()
        {
            string StrSql = "select * from Department";
            return SqlDBHelper.GetDataTable(StrSql);
        }
        /// <summary>
        /// 资产分类
        /// </summary>
        /// <returns></returns>
        public DataTable comClassID()
        {
            string StrSql = "select * from PropertyClass";
            return SqlDBHelper.GetDataTable(StrSql);
        }
        /// <summary>
        /// 仓库
        /// </summary>
        /// <returns></returns>
        public DataTable comRepID()
        {
            string StrSql = "select * from Repertory";
            return SqlDBHelper.GetDataTable(StrSql);
        }
        /// <summary>
        /// 折旧方法
        /// </summary>
        /// <returns></returns>
        public DataTable comOldInfo()
        {
            string StrSql = "select * from Repertory";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public DataTable ItemLoad(string id)
        {
            string StrSql = @"select F_proID,GoodsID,GoodsName,SumOld,CalssName,OldInfo,Type,MakeName,OldMonth,IntoDate,RepName,Sub_Month,DepName,State,Month_Money,AddType,Quantity ,JingCanZhi,OrderUnit,Price,Detail,Money,Pro_value
 from Goods,Department,PropertyClass,Repertory where Goods.DepID=Department.DepID and Goods.ClassID=PropertyClass.ClassID and Repertory.RepID=Goods.RepID and GoodsName='" + id + "'";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public DataTable BorrowLoad(string id)
        {
            string StrSql = "select F_proID from Goods where GoodsName='" + id + "'";
            return SqlDBHelper.GetDataTable(StrSql);
        }
        public DataTable BorrowdataLoad(string id)
        {
            string StrSql = string.Format(@"select ID,borrow.F_proID,GoodsName,PropertyClass.CalssName,NowDate,Borrow_sum,Borrow_Date,Predict_date,Predict_money,borrow.Money,Company,CustomerID,borrow.Detail          
 from Borrow,Goods,PropertyClass where borrow.F_proID=Goods.F_proID and PropertyClass.ClassID=Goods.ClassID");
            DataTable dt = SqlDBHelper.GetDataTable(StrSql);
            foreach (DataRow item in dt.Rows)
            {
                if (id == item["CalssName"].ToString())
                {
                    StrSql = string.Format(@"select ID,borrow.F_proID,GoodsName,PropertyClass.CalssName,NowDate,Borrow_sum,Borrow_Date,Predict_date,Predict_money,borrow.Money,Company,CustomerID,borrow.Detail       
 from Borrow,Goods,PropertyClass where borrow.F_proID=Goods.F_proID and PropertyClass.ClassID=Goods.ClassID and  
CalssName = '{0}'", id);
                }
                else
                {
                    StrSql = string.Format(@"select ID,borrow.F_proID,GoodsName,PropertyClass.CalssName,NowDate,Borrow_sum,Borrow_Date,Predict_date,Predict_money,borrow.Money,Company,CustomerID,borrow.Detail        
 from Borrow,Goods,PropertyClass where borrow.F_proID=Goods.F_proID and PropertyClass.ClassID=Goods.ClassID and  
GoodsName = '{0}'", id);
                }
            }


            return SqlDBHelper.GetDataTable(StrSql);
        }
        public DataTable dataBorrowLoad()
        {
            string StrSql = @"select ID,borrow.F_proID,GoodsName,PropertyClass.CalssName,Borrow_sum,NowDate,Borrow_Date,Predict_date,Predict_money,borrow.Money,Company,CustomerID,borrow.Detail     
 from Borrow, Goods, PropertyClass where borrow.F_proID = Goods.F_proID and PropertyClass.ClassID = Goods.ClassID";
            return SqlDBHelper.GetDataTable(StrSql);
        }
    }
}
