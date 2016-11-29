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
	public class DangKyBLL
	{
		DangKyDAL dal = new DangKyDAL();
		public DangKyDTO[] getList()
		{
			return dal.GetList();
		}
		public bool Them(DangKy dangky)
		{
			return false;
		}
		public bool Xoa(DangKy dangky)
		{
			return false;
		}
		
	}

	
}
