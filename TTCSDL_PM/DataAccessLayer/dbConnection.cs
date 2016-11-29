using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_PM.DataAccessLayer
{
	class dbConnection
	{
		private SqlDataAdapter adapter;
		private SqlConnection conn;

		public dbConnection()
		{
			conn = new SqlConnection(@"Server =DESKTOP-PN25S1D\MYSQL ; Database= TTCSDL_PM; Trusted_Connection = true");
			//conn = new SqlConnection(ConfigurationSettings.AppSettings["dbConnectionString"]);
		}
		private SqlConnection OpenConnection()
		{
			if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
			{
				conn.Open();
			}
			return conn;
		}
		public DataTable executeSelectQuery(String query, SqlParameter[] sqlParameter)
		{
			SqlCommand command = new SqlCommand();
			DataTable dataTable = new DataTable();
			adapter = new SqlDataAdapter();
			dataTable = null;
			DataSet ds = new DataSet();
			try
			{
				command.Connection = OpenConnection();
				command.CommandText = query;
				command.Parameters.AddRange(sqlParameter);
				command.ExecuteNonQuery();
				adapter.SelectCommand = command;
				adapter.Fill(ds);
				dataTable = ds.Tables[0];
			}
			catch (SqlException e)
			{
				return null;
			}
			return dataTable;
		}
	}
}
