using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCSDL_PM.DataAccessLayer;
using TTCSDL_PM.DataTransferObject;
using System.Configuration;
namespace TTCSDL_PM.Model
{
	public class KetNoiSQL
	{
		DangKyDAL dal = new DangKyDAL();
		//public DangKyDAL[] HienThiDanhSach()
		//{
		//	DangKyDAL[] list;
		//	DataTable table = null;

		//	int n = 0;

			
		//	return null;
		//}
		public bool Them(DangKy dangky)
		{
			return false;
		}
		public bool Xoa(DangKy dangky)
		{
			return false;
		}
		
	}

	class DataHelper
	{
		private static SqlConnection _connection= null;
		public DataHelper()
		{
			//var connStr = confi ConfigurationManager.AppSettings["ConnectionString"];
			String connStr = "";
			_connection = new SqlConnection(connStr);
		}
		/// <summary>
		/// execute select query
		/// </summary>
		/// <param name="query">a string of select query</param>
		/// <returns></returns>
		public DataTable ExecuteQuery(string query)
		{
			//to do something
			return null;
		}
		public void ExecuteNonQuery(string query)
		{
		
		}
	}
}
