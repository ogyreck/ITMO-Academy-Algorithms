using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://codeforces.com/edu/course/2/lesson/3/1/practice/contest/272260/problem/B

namespace ITMO_Academy.Z_функция
{
	public static class B1

	{
		public static void RunTask()
		{
			int n = int.Parse(Console.ReadLine());
			List<int> result = new List<int>();
			
			for(int q = 0; q < n; q++)
			{
				int count = 0;
				string s = Console.ReadLine();
				
				for (int i = 0; i < s.Length; i++)
				{
					string substr =  "" ;
					
					for(int j = i; j < s.Length; j++)
					{
						substr += s[j];
						if ((isInPrefics(s, substr) || isInSyfics(s, substr)) && !(isInPrefics(s, substr) && isInSyfics(s, substr)))
						{
							count++;

						}
					}


				}

				result.Add(count);

			}

			foreach(var  i in result)
			{
				Console.WriteLine(i);
			}
		}


		static bool isInPrefics(string text, string substring)
		{
			if (substring.Length > text.Length) return false;
			string prefix = text.Substring(0, substring.Length);
			return prefix == substring;
		}

		static bool isInSyfics(string text, string substring)
		{
			if (substring.Length > text.Length) return false;
			string suffix = text.Substring(text.Length - substring.Length, substring.Length);
			return suffix == substring;
		}

	}
}
