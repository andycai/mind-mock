using System;

namespace Mind.Mock
{
    public partial class Rand 
    {
		private static string format(int type = 0, string fmt = "yyyy-MM-dd")
		{
			Random rd = new Random(GetRandomSeed());
			DateTime now = DateTime.Now;
			int days = rd.Next(0, 9999);
			int hour = rd.Next(0, 23);
			int minute = rd.Next(0, 60);
			int second = rd.Next(0, 60);
			var d = now.AddDays(-days);

			var dstr = "";
			switch (type)
			{
				case 0:
					dstr = d.ToString(fmt);
					break;
				case 1:
					dstr = string.Format("{0}:{1}:{2}", hour, minute, second);
					break;
				case 2:
					dstr = string.Format("{0} {1}:{2}:{3}", d.ToString(fmt), hour, minute, second);
					break;
			}

			return dstr;
		}

		// 随机生成一个日期字符串
		public static string Date(string fmt = "yyyy-MM-dd")
		{
			return format(0, fmt);
		}

		// 随机生成一个时间字符串
		public static string Time(string fmt = "yyyy-MM-dd")
		{
			return format(1, fmt); 
		}

		// 随机生成一个具体日期和时间字符串
		public static string Datetime(string fmt = "yyyy-MM-dd")
		{
			return format(2, fmt); 
		}

		// 返回当前的日期字符串
		public static string Now(string fmt = "yyyy-MM-dd HH:mm:ss")
		{
			return DateTime.Now.ToString(fmt); 
		}
	}
}