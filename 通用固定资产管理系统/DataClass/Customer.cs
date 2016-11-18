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
    /// 用户表
    /// </summary>
    class Customer:IDAO
    {

        private int customerID;
        private string  login;
        private string customerName;
        private string pwd;
        private string depID;
        private int roleID;
        /// <summary>
        /// 用户ID
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
        /// 登录名
        /// </summary>
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd
        {
            get
            {
                return pwd;
            }

            set
            {
                pwd = value;
            }
        }
        /// <summary>
        /// 用户所在部门
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
        /// 用户所属角色
        /// </summary>
        public int RoleID
        {
            get
            {
                return roleID;
            }

            set
            {
                roleID = value;
            }
        }

        public bool Add()
        {
            string StrSql = string.Format("insert into Customer values('{0}','{1}','{2}','{3}',{4})",this.Login,this.CustomerName,this.Pwd,this.DepID,this.RoleID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Update()
        {
            string StrSql = string.Format("UPDATE Customer SET [Login] ='{0}' ,[CustomerName] ='{1}'  ,[Pwd] ='{2}'  ,[DepID] ='{3}' ,[RoleID] ='{4}' WHERE  CustomerID='{5}'", this.Login,this.CustomerName,this.Pwd,this.DepID,this.RoleID,this.CustomerID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            string StrSql = string.Format("DELETE FROM Customer where CustomerID='{0}'", id);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = "select * from Customer";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable comDepID()
        {
            string StrSql = "select Department.DepID, DepName from Customer,Department where Customer.DepID=Department.DepID";
            return SqlDBHelper.GetDataTable(StrSql);
        }
        public DataTable role()
        {
            string StrSql = "select Role.RoleID, RoleName from Customer,Role where Customer.RoleID=Role.RoleID";
            return SqlDBHelper.GetDataTable(StrSql);
        }
        public  DataTable comDepIDLoad()
        {
            string StrSql = "select * form Department";
            return SqlDBHelper.GetDataTable(StrSql);
        }
    }
}
