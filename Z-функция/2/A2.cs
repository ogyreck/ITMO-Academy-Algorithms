using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Academy.Z_функция._2
{
	public static class A2
	{
		public static void RunTask()
		{
			string s = Console.ReadLine();
			int[] zFunction = new int[s.Length];
			zFunction[0] = 0;
			for(int  i = 1; i < s.Length; i++)
			{
				string p = s.Substring(i);
				zFunction[i] = lengthCommonMaxPreffix(s,p);
			}

			foreach(var q in  zFunction)
			{
				Console.Write(q + " ");
			}
		}

		static int lengthCommonMaxPreffix(string text, string suffix)
		{
			int count = 0;
			int index1 = 0;
			int index2 = 0;
			for(int  i = 0; i < text.Length - (text.Length - suffix.Length); i++)
			{
				if (text[index1] == suffix[index2])
				{
					count++;
					index1++;
					index2++;
				}
				else
				{
					return count;
				}
			}
			return count;
		}
	}
}
