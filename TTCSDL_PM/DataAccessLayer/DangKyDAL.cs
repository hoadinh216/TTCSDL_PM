using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCSDL_PM.DataTransferObject;

namespace TTCSDL_PM.DataAccessLayer
{
	public class DangKyDAL
	{
		private ConnectionDAL conn;
		public DangKyDAL()
		{
			conn = new ConnectionDAL();
		}
		public DangKyDTO GetDangKyFromDataRow(DataRow row)
		{
			DangKyDTO dangKyDTO = new DangKyDTO();

			dangKyDTO.Ma = row["ma"].ToString().Trim();
			//dangKyDTO.Ngay = row["ngay"].ToString().Trim();
			//if (DateTime.TryParse(row["ngay"].ToString(), out birthDate) == true)
			//{

			//	// Success case
			//}
			dangKyDTO.Tiet = row["tiet"].ToString().Trim();
			dangKyDTO.YeuCau = row["yeucau"].ToString().Trim();
			dangKyDTO.NoiDung = row["noidung"].ToString().Trim();
			dangKyDTO.LopHocPhanMa = row["lophocphanma"].ToString().Trim();
			dangKyDTO.GiaoVienGiangDayMa = row["giaoviengiangdayma"].ToString().Trim();
			dangKyDTO.GiaoVienXacNhanMa = row["giaovienxacnhanma"].ToString().Trim();
			dangKyDTO.PhongMayMa = row["phongmayma"].ToString().Trim();
			//dangKyDTO.ThoiGianDangKy = row["thoigiandangky"].ToString().Trim();
			dangKyDTO.KieuDangKy = row["kieudangky"].ToString().Trim();
			dangKyDTO.XacNhan = row["xacnhan"].ToString().Trim();

			return dangKyDTO;
		}

		public DangKyDTO[] GetList()
		{
			DangKyDTO[] list = null;
			DataTable table = null;
			int n = 0;

			table = conn.ExecuteQuery("SELECT * FROM dangky");
			n = table.Rows.Count;
			if (n == 0)
			{
				return null;
			}
			list = new DangKyDTO[n];
			for (int i = 0; i < n; i++)
			{
				DangKyDTO dangky = GetDangKyFromDataRow(table.Rows[i]);
				list[i] = dangky;
			}
			return list;
		}
		
	}
}
