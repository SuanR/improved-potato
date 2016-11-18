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
    class Menu:IDAO
    {
        private int menuID;
        private string menuName;
        private int parentID;
        private string formClass;
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
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName
        {
            get
            {
                return menuName;
            }

            set
            {
                menuName = value;
            }
        }
        /// <summary>
        /// 父级ID
        /// </summary>
        public int ParentID
        {
            get
            {
                return parentID;
            }

            set
            {
                parentID = value;
            }
        }
        /// <summary>
        /// 窗体对应的类
        /// </summary>
        public string FormClass
        {
            get
            {
                return formClass;
            }

            set
            {
                formClass = value;
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
