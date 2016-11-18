using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八章_接口
{
    /// <summary>
    /// 实体数据操作接口
    /// </summary>
    interface IDAO
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns>是否添加成功</returns>
        bool Add();

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns>是否更新成功</returns>
        bool Update();
        /// <summary>
        /// 根据主键id删除数据
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns>是否删除成功</returns>
        bool Delete(string id);

        /// <summary>
        /// 根据条件查询多条数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns>存放多条数据的DataTable</returns>
        DataTable SelectListByWhere(string strWhere);

        /// <summary>
        /// 根据主键id查询单条数据，赋值给对象的属性
        /// </summary>
        /// <param name="id">主键id</param>
        void SelectModelById(string id);

        
    }
}
