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
    /// 部门表
    /// </summary>
    class Department : IDAO
    {
        private string depID;
        private string depNAme;
        /// <summary>
        /// 部门编号
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
        /// 部门名称
        /// </summary>
        public string DepNAme
        {
            get
            {
                return depNAme;
            }

            set
            {
                depNAme = value;
            }
        }

        public bool Add()
        {
            string StrSql = string.Format("insert Department values('{0}','{1}')",this.DepID, this.DepNAme);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            string StrSql = "delete from Department where DepID='" + id + "'";
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = "select * from Department";
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            string StrSql = string.Format("Update Department set DepName='{0}' where DepID='{1}'", this.DepNAme, this.DepID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }
    }
}
