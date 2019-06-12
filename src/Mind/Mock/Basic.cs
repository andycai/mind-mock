using System;
using System.Text;

namespace Mind.Mock
{
    public partial class Rand
    {
		// 返回一个随机的布尔值
		public static bool Bool()
		{
			Random rd = new Random(GetRandomSeed());
			return rd.Next(0, 10) > 5;
		}

		// 返回一个随机的自然数（大于等于0的整数）
		public static int Natural(int min = 0, int max = 0)
		{
			Random rd = new Random(GetRandomSeed());
			min = min < 0 ? 0 : min;
			max = max <= 0 ? (int)Math.Pow(2.0, 16.0) : max;

			return rd.Next(min, max);
		}

		// 返回一个随机的整数
		public static int Int(int min = 0, int max = 0)
		{
			if (max == 0)
			{
				min = -(int)Math.Pow(2.0, 16.0);
				max = (int)Math.Pow(2.0, 16.0);
			}
			Random rd = new Random(GetRandomSeed());
			return rd.Next(min, max);
		}

		// 返回一个随机的浮点数
		public static float Float(int min = 0, int max = 0, int dmin = 0, int dmax = 0)
		{
			string result = "";

			result += Natural(min, max) + ".";
			result += Natural(dmin, max);

			return Convert.ToSingle(result);
		}

		private static char[] constant =
		{
			'0','1','2','3','4','5','6','7','8','9',
			'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
			'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
			'!','@', '#', '$', '%', '^', '&', '*', '(', ')', '[', ']'
		};
		// 返回一个随机字符
		public static char Char(string type = "alpha")
		{
			Random rd = new Random(GetRandomSeed());
			var c = constant[rd.Next(0, 74)];

			switch (type)
			{
				case "all":
					c = constant[rd.Next(0, 74)];
					break;
				case "alpha":
					c = constant[rd.Next(11, 62)];
					break;
				case "lower":
					c = constant[rd.Next(11, 36)];
					break;
				case "upper":
					c = constant[rd.Next(38, 62)];
					break;
				case "number":
					c = constant[rd.Next(0, 10)];
					break;
				case "symbol":
					c = constant[rd.Next(63, 74)];
					break;
				default:
					var pool = type.ToCharArray();
					c = pool[rd.Next(0, pool.Length)];
					break;
			}
			
			return c;
		}

		// 返回一个随机字符串
		public static string String(string pool, int min, int max = 0)
		{
			StringBuilder str = new StringBuilder(62);
			int len = 0;
			if (max == 0)
			{
				len = min;
			}
			else
			{
				Random rd = new Random(GetRandomSeed());
				len = rd.Next(min, max);
			}
			for (int i = 0; i < len; i++)
			{
				str.Append(Char(pool));	
			}

			return str.ToString();
		}

		// 返回一个整型数组
		public static int[] Range(int start, int stop = 0, int step = 1)
		{
			if (stop == 0)
			{
				stop = start;
				start = 0;
			}

			int len = Math.Max((int) Math.Ceiling((double) ((stop - start) / step)), 0);
			int[] range = new int[len];
			int idx = 0;

			while (idx < (stop - start))
			{
				range[idx++] = start;
				start += step;
			}

			return range;
		}
	}
}