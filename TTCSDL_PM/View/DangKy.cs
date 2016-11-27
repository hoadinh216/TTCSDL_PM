using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCSDL_PM.Object;

namespace TTCSDL_PM
{
	public partial class DangKy : Form
	{
		Form frm_dangnhap;
		SqlConnection conn;
		SqlDataAdapter da_DangKy;
		DataSet ds_QLDV;
		GiaoVien gv_obj;
		public DangKy(Form frm_dangnhap, String taiKhoan, String MatKhau)
		{
			InitializeComponent();
			this.frm_dangnhap = frm_dangnhap;
			gv_obj = new GiaoVien();
			gv_obj.TaiKhoan = taiKhoan;
			gv_obj.MatKhau = MatKhau;
		}

		private void DangKy_Load(object sender, EventArgs e)
		{
			conn = new SqlConnection(@"Server = DESKTOP-PN25S1D\MYSQL; Database= TTCSDL_PM; Trusted_Connection = true");
			conn.Open();//tạo kết nối sql


			da_DangKy = new SqlDataAdapter("SELECT *FROM dangky", conn);
			ds_QLDV = new DataSet();
			da_DangKy.Fill(ds_QLDV, "dangky");
			dgvDangKy.DataSource = ds_QLDV.Tables["dangky"];
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{

		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnSua_Click(object sender, EventArgs e)
		{

		}

		private void tpDangKy_Click(object sender, EventArgs e)
		{

		}

		private void btnHuyy_Click(object sender, EventArgs e)
		{

		}

		private void lblThoat_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			this.frm_dangnhap.Visible = true;
		}

		private void lblThoat_Click(object sender, FormClosedEventArgs e)
		{
			this.Visible = false;
			this.frm_dangnhap.Visible = true;
		}
	}
}
