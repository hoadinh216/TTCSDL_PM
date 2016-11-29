using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_PM.DataAccessLayer
{
	public class ConnectionDAL
	{
		private SqlConnection conn;

		public ConnectionDAL()
		{
			conn = new SqlConnection(@"Server =DESKTOP-PN25S1D\MYSQL ; Database= TTCSDL_PM; Trusted_Connection = true");
			//conn = new SqlConnection(ConfigurationSettings.AppSettings["dbConnectionString"]);
		}
		public DataTable ExecuteQuery(string query)
		{
			DataTable table = new DataTable();
			try {
				conn.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				adapter.Fill(table);
			}
			catch (Exception ex)
			{
				throw new Exception("Exccute query error: " + ex.Message);
			}
			return table;
		}
		public void ExecuteNonQuery(String query)
		{
			SqlCommand command = new SqlCommand(query, conn);
			try
			{
				conn.Open();
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception("Execute non query error: " + e.Message);
			}
			finally
			{
				if (conn != null)
				{
					conn.Close();
				}
				if (command != null)
				{
					command.Dispose();
				}
			}
		}
	}
}
