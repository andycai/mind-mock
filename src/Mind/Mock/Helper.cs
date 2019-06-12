using System;
using System.Collections.Generic;

namespace Mind.Mock
{
    public partial class Rand 
    {
		public static int GetRandomSeed()
		{
			byte[] bytes = new byte[4];
			System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
			rng.GetBytes(bytes);
			return BitConverter.ToInt32(bytes, 0);

			//return unchecked((int)DateTime.Now.Ticks);

			//long tick = DateTime.Now.Ticks;
			//return (int)(tick & 0xffffffffL) | (int)(tick >> 32);
			//return (int)DateTime.Now.Ticks;
			//return new Guid().GetHashCode(); 
		}

		// 返回精确的随机数
		public static int GetRandom(int min, int max)
		{
			Random rd = new Random(GetRandomSeed());
			return rd.Next(min, max);
		}

		// 首字母大写
		public static string Capitalize(string word)
		{
			return word.Substring(0, 1).ToUpper() + word.Substring(1);
		}

		// 转为大写字母
		public static string Upper(string str)
		{
			return str.ToUpper(); 
		}

		// 转为小写字母
		public static string Lower(string str)
		{
			return str.ToLower();
		}

		// 随机获取List中的一项
		public static T Pick<T>(List<T> list, int min = 0, int max = 0)
		{
			int len = list.Count;
			Random rd = new Random(GetRandomSeed());
			if (max == 0)
			{
				min = 0;
				max = len;
			}
			if (min < 0) min = 0;
			if (max > len) max = len-1;

			return list[rd.Next(min, max)];
		}
	}
}