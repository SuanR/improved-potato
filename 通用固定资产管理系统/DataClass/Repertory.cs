using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 第八章_接口;
using CSharpProjectDemo.DAL;
using System.Threading.Tasks;
using System.Data;

namespace 通用固定资产管理系统.NewFolder1
{
    class Repertory : IDAO
    {
        /// <summary>
        /// 仓库编号
        /// </summary>
        private string repID;
        /// <summary>
        /// 仓库名称
        /// </summary>
        private string repName;
        /// <summary>
        /// 仓库说明
        /// </summary>
        private string repPosition;

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

        public string RepName
        {
            get
            {
                return repName;
            }

            set
            {
                repName = value;
            }
        }

        public string RepPosition
        {
            get
            {
                return repPosition;
            }

            set
            {
                repPosition = value;
            }
        }

        public bool Add()
        {
            string StrSql = string.Format("INSERT INTO Repertory VALUES('{0}','{1}','{2}')", this.RepID, this.RepName,this.RepPosition);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Update()
        {
            string StrSql = string.Format("UPDATE Repertory SET RepName = '{0}', RepPosition='{1}' where RepID='{2}'",  this.RepName, this.RepPosition, this.RepID);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public bool Delete(string id)
        {
            string StrSql = string.Format("DELETE FROM Repertory where RepID='{0}'", id);
            return SqlDBHelper.ExecuteNonQuery(StrSql);
        }

        public DataTable SelectListByWhere(string strWhere)
        {
            string StrSql = "select * from Repertory";            
            return SqlDBHelper.GetDataTable(StrSql);
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }
      
    }
}
