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
    /// 权限表
    /// </summary>
    class Powers:IDAO
    {
        private int powersID;
        private int customerID;
        private int menuID;
        /// <summary>
        /// 主键
        /// </summary>
        public int PowersID
        {
            get
            {
                return powersID;
            }

            set
            {
                powersID = value;
            }
        }
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
        /// 菜单ID
        /// </summary>
        public int MenuID
        {
            get
            {
                return menuID;
            }

            set
            {
                menuID = value;
            }
        }

        public bool Add()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void SelectModelById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
