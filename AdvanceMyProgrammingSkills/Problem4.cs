using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceMyProgrammingSkills
{
	class Problem4
	{
		// A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit
		// numbers is 9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers.

		public static void Palindromic()
		{
			int N;
			int[] d= new int[6];
			int c0, c1 = 0;
			int[] Pal = new int[2000];


			for (int i = 999; i >= 100; i--)
			{
				for (int j = 999; j >= 100; j--)
				{
					N = i * j;
					c0 = 0;

					while (N > 0)
					{
						d[c0] = N % 10;
						N = (N - d[c0]) / 10;
						c0++;
					}

					if (d[0] == d[5] && d[1] == d[4] && d[2] == d[3])
					{
						Pal[c1] = int.Parse(d[5].ToString() + d[4].ToString() + d[3].ToString() + d[2].ToString() + d[1].ToString() + d[0].ToString());
						c1++;
					}

					//if (N == 906609)
					//{
					//	Console.WriteLine(d[5]);
					//}


					//if (N == 580085)
					//{
					//	Console.WriteLine(d[5]);
					//}
				}

			}
						
			Console.WriteLine(Pal.Max());
		
		}


	}
}