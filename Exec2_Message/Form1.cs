using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class frmGreet : Form
	{
		public frmGreet()
		{
			InitializeComponent();
		}

		private void btnTimeGreet_Click(object sender, EventArgs e)
		{
			lblGreetTime.Text =Display();
			string dt = DateTimeNow();
			MessageBox.Show(dt,"時間顯示",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private string DateTimeNow()
		{
			DateTime dt = DateTime.Now;
			string datetime = $"現在時間是\r\n{dt:yyyy/MM/dd HH:mm:ss}";
			return datetime;
		}

		private string Display()
		{
			DateTime now = DateTime.Now;
			string msg = GetGreet();
			string result = $"{now:HH:mm}\r\n{msg}";
			return result;
		}

		private string GetGreet()
		{
			DateTime dateTime = DateTime.Now;
			string msg = string.Empty;
			int hour = dateTime.Hour;
			if (hour < 11) 
			{
				msg = "早安!";
			}
			if (hour < 18)
			{
				msg = "午安!";
			}
			else
			{
				msg = "晚安!";
			}
			return msg;
		}
	}
}
