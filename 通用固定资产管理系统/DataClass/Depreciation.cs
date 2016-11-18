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
    class Depreciation:IDAO
    {
        private int depreciationID;
        private string years;
        private string months;
        private float depreciationMoney;
        private string f_proID;

        public int DepreciationID
        {
            get
            {
                return depreciationID;
            }

            set
            {
                depreciationID = value;
            }
        }

        public string Years
        {
            get
            {
                return years;
            }

            set
            {
                years = value;
            }
        }

        public string Months
        {
            get
            {
                return months;
            }

            set
            {
                months = value;
            }
        }

        public float DepreciationMoney
        {
            get
            {
                return depreciationMoney;
            }

            set
            {
                depreciationMoney = value;
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
