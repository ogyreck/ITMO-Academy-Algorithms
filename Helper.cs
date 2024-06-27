using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Academy
{
	public static class Helper
	{
		public static bool isPolindrom(string s)
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
