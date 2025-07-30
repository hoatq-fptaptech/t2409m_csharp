using System;
namespace T2409M_CSharp.session3
{
	public class ChamSocKhachHang
	{
		public event SendNotify ThongBao;

		public ChamSocKhachHang()
		{
			ThongBao = new SendNotify(Box.SMS);
			ThongBao += Box.Email;
			ThongBao += Box.Zalo;
			ThongBao += Box.Telegram;
		}

		public void GuiThongBao(string tel,string msg)
		{
			ThongBao(tel, msg);
		}
	}
}

