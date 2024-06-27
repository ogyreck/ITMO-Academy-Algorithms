using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Academy.Z_функция
{
	public static class A1
	{
		public static void RunTask()
		{
			int n = int.Parse(Console.ReadLine());
			List<int> results = new List<int>();

			for (int i = 0; i < n; i++)
			{
				string s = Console.ReadLine();
				int longSubStirngLength = 0;
				string resS = "";
				for (int j = 0; j < s.Length; j++)
				{
					resS += s[j];
					if (isPolindrom(resS))
					{
						longSubStirngLength = resS.Length;
					}
				}

				results.Add(longSubStirngLength);
			}

			foreach (var i in results)
			{
				Console.WriteLine(i);
			}

			static bool isPolindrom(string s)
			{
				string sRevrse = "";
				for (int i = s.Length - 1; i >= 0; i--)
				{
					sRevrse += s[i];
				}

				if (sRevrse == s)
				{
					return true;
				}
				return false;
			}
		}
	}
}






