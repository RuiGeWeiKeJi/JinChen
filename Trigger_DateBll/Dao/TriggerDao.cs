using StudentMgr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigger_DateBll.Dao
{
    public class TriggerDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.AppendFormat( "SELECT DISTINCT RAA015 FROM SGMRAA WHERE RAA001 LIKE '%{0}%' AND RAA002 IN ('需求','')" ,DateTime.Now.ToString( "yyyyMMdd" ) );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取车间信息
        /// </summary>
        /// <param name="odd"></param>
        /// <returns></returns>
        public DataTable GetDataTableDea (string odd )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DEA961 FROM TPADEA A,SGMRAA B " );
            strSql.AppendFormat( "  WHERE A.DEA001=B.RAA015 AND RAA001 LIKE '%{0}%' AND RAA015='{1}'" ,DateTime.Now.ToString( "yyyyMMdd" ) ,odd );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="odd"></param>
        /// <returns></returns>
        public bool Update (string oteher, string odd )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.AppendFormat( "UPDATE SGMRAA SET RAA002='{0}' WHERE RAA015='{1}' AND RAA001 LIKE '%{2}%'" ,oteher ,odd ,DateTime.Now.ToString( "yyyyMMdd" ) );

            int row = SqlHelper.ExecuteNonQuery( strSql.ToString( ) );
            if ( row > 0 )
                return true;
            else
                return false;
        }
    }
}
