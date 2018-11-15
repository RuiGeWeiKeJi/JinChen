using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigger_DateBll.Bll
{
    public class TriggerBll
    {
        Dao.TriggerDao _dao = new Dao.TriggerDao( );
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( )
        {
            return _dao.GetDataTable( );
        }

        /// <summary>
        /// 获取车间信息
        /// </summary>
        /// <param name="odd"></param>
        /// <returns></returns>
        public DataTable GetDataTableDea ( string odd )
        {
            return _dao.GetDataTableDea( odd );
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="odd"></param>
        /// <returns></returns>
        public bool Update ( string oteher ,string odd )
        {
            return _dao.Update( oteher ,odd );
        }
    }
}
