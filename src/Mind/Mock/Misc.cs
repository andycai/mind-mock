using System;

namespace Mind.Mock
{
    public partial class Rand 
    {
		/*
	    随机生成一个 GUID。
	    http://www.broofa.com/2008/09/javascript-uuid-function/
	    [UUID 规范](http://www.ietf.org/rfc/rfc4122.txt)
	        UUIDs (Universally Unique IDentifier)
	        GUIDs (Globally Unique IDentifier)
	        The formal definition of the UUID string representation is provided by the following ABNF [7]:
	            UUID                   = time-low "-" time-mid "-"
	                                   time-high-and-version "-"
	                                   clock-seq-and-reserved
	                                   clock-seq-low "-" node
	            time-low               = 4hexOctet
	            time-mid               = 2hexOctet
	            time-high-and-version  = 2hexOctet
	            clock-seq-and-reserved = hexOctet
	            clock-seq-low          = hexOctet
	            node                   = 6hexOctet
	            hexOctet               = hexDigit hexDigit
	            hexDigit =
	                "0" / "1" / "2" / "3" / "4" / "5" / "6" / "7" / "8" / "9" /
	                "a" / "b" / "c" / "d" / "e" / "f" /
	                "A" / "B" / "C" / "D" / "E" / "F"
	    
	    https://github.com/victorquinn/chancejs/blob/develop/chance.js#L1349
		*/
		// 随机生成一个 GUID
		public static string Guid()
		{
			var pool = "abcdefABCDEF1234567890";
			var	guid = String(pool, 8) + '-' +
				String(pool, 4) + '-' +
				String(pool, 4) + '-' +
				String(pool, 4) + '-' +
				String(pool, 12);
			return guid;
		}

		public static string UUID()
		{
			return Guid();
		}

		/*
	    随机生成一个 18 位身份证。
	    [身份证](http://baike.baidu.com/view/1697.htm#4)
	        地址码 6 + 出生日期码 8 + 顺序码 3 + 校验码 1
	    [《中华人民共和国行政区划代码》国家标准(GB/T2260)](http://zhidao.baidu.com/question/1954561.html)
		*/
		public static string Id()
		{
			var id = "";
			var sum = 0;
			string[] rank = {
				"7", "9", "10", "5", "8", "4", "2", "1", "6", "3", "7", "9", "10", "5", "8", "4", "2"
			};
			string[] last = {
				"1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2"
			};
			id = CountyId() + Date("yyyyMMdd") + String("number", 3);

			for (var i = 0; i < id.Length; i++)
			{
				sum += (int)id[i] * Convert.ToInt16(rank[i]);
			}
			id += last[sum % 11];

			return id;
		}

		private static Func<int, int> increment()
		{
			int key = 0;
			Func<int, int> inc = (x) => key += x;

			return inc;
		}

		private static Func<int, int> _incr;

		// 生成一个全局的自增整数
		public static int Incr(int step = 1)
		{
			if (_incr == null)
			{
				_incr = increment();
			}

			return _incr(step);	
		}
	}
}