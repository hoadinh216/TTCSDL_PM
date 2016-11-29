using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_PM.DataAccessLayer
{
	class DangKyDAL
	{
		private dbConnection conn;
		public DangKyDAL()
		{
			conn = new dbConnection();
		}
		public DataTable getAllCus()
		{
			string query = string.Format("SELECT *FROM dangky");
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return conn.executeSelectQuery(query, sqlParameters);
		}
		public DataTable SearchById(int ma)
		{
			//string query = "SELECT *FROM dangky WHERE ma = @ma";
			//SqlParameter[] sqlParameters = new SqlParameter[1];
			//sqlParameters[0] = new SqlParameter("@ma", SqlDbType.)
			return null;
		}
	}
}
