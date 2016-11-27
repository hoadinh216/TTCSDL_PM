using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL_PM
{
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();

		}
		private void DangNhap_Load(object sender, EventArgs e)
		{

		}

		private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Visible = false;
			Application.Exit();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			String taiKhoan = txbTaiKhoan.Text.ToString();
			String matKhau = txbMatKhau.Text.ToString();
			DangKy frm_dangky = new DangKy(this, taiKhoan, matKhau);
			frm_dangky.Visible = true;
			this.Visible = false;

		}
	}
}
