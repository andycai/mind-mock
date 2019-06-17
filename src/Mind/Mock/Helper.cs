using System;
using System.Collections.Generic;

namespace Mind.Mock
{
    public partial class Rand 
    {
		/// <summary>
		/// 获取随机种子
		/// </summary>
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

		/// <summary>
		/// 返回精确的随机数
		/// </summary>
		public static int GetRandom(int min, int max)
		{
			Random rd = new Random(GetRandomSeed());
			return rd.Next(min, max);
		}

		/// <summary>
		/// 首字母大写
		/// </summary>
		public static string Capitalize(string word)
		{
			return word.Substring(0, 1).ToUpper() + word.Substring(1);
		}

		/// <summary>
		/// 转为大写字母
		/// </summary>
		public static string Upper(string str)
		{
			return str.ToUpper(); 
		}

		/// <summary>
		/// 转为小写字母
		/// </summary>
		public static string Lower(string str)
		{
			return str.ToLower();
		}

		/// <summary>
		/// 随机获取List中的一项
		/// </summary>
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