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
    /// 角色表
    /// </summary>
    class Role : IDAO
    {
        private int roleID;
        private string roleName;
        private string roleTxt;
        /// <summary>
        /// 角色ID
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
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName
        {
            get
            {
                return roleName;
            }

            set
            {
                roleName = value;
            }
        }
        /// <summary>
        /// 角色描述
        /// </summary>
        public string RoleTxt
        {
            get
            {
                return roleTxt;
            }

            set
            {
                roleTxt = value;
            }
        }

        public bool Add()
        {
            string StrSql = string.Format("insert Role values('{0}','{1}')", this.RoleName, this.RoleTxt);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            string StrSql = "delete from Role where RoleID='" + this.RoleID + "'";
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = string.Format("select * from Role");
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            string StrSql = string.Format("Update Role set RoleName='{0}',RoleTxt='{1}' where RoleID='{2}'", this.RoleName, this.RoleTxt,this.RoleID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }
    }
}
