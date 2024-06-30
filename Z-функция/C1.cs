using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Academy.Z_функция
{
	public static class C1
	{
		public static void RunTask()
		{
			int n = int.Parse(Console.ReadLine());

			List<List<List<int>>> results = new List<List<List<int>>>();

			for(int q= 0; q < n; q++)
			{
				string t = Console.ReadLine();
				string p = Console.ReadLine();
				int count = 0;
				List<List<int>> ans = new List<List<int>>();
				if (p.Length <= t.Length)
				{
					List<int> list = new List<int>();
					for (int i = 0; i < t.Length-p.Length+1; i++)
					{
						string subString = t.Substring(i, p.Length);
						if (checkJoker(subString, p))
						{
							count++;
							list.Add(i);
						}
					}

					List<int> countList = new List<int>() { count };
					ans.Add(countList);
					ans.Add(list);
				}
				else
				{
					List<int> countList1 = new List<int>() { 0 };
					ans.Add(countList1);
					ans.Add(new List<int>());
				}
				results.Add(ans);
			}

			foreach(var i  in results)
			{
				
				foreach(var e in i[0])
				{
					Console.WriteLine(e);
				}
				foreach (var j in i[1])
					{
						Console.Write(j + " ");
					}
				Console.WriteLine();

			}
		}

		static bool checkJoker(string text, string joker)
		{
			if (joker.Length > text.Length) return false;
			int count = 0;
			for(int i = 0; i < text.Length; i++)
			{
				if (text[i] == joker[i] || joker[i] == '?')
				{
					count++;
				}
			}
			if (count == text.Length) return true;
			return false;

		}
	}
}
