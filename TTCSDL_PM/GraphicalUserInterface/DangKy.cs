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
using TTCSDL_PM.DataTransferObject;

namespace TTCSDL_PM
{
	public partial class DangKy : Form
	{
		Form frm_dangnhap;
		public DangKy(Form frm_dangnhap, String taiKhoan, String MatKhau)
		{
			InitializeComponent();
			this.frm_dangnhap = frm_dangnhap;
		
		}

		private void DangKy_Load(object sender, EventArgs e)
		{

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
