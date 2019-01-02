using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AdvanceMyProgrammingSkills
{
	class Problem12
	{
	/*  # The first ten terms would be:
		#   1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ... 
		# Let us list the factors of the first seven triangle numbers: 
		#     1:  1
		#     3:  1,3
		#     6:  1,2,3,6
		#     10: 1,2,5,10
		#     15: 1,3,5,15
		#     21: 1,3,7,21
		#     28: 1,2,4,7,14,28
		#     
		# We can see that 28 is the first triangle number to have over five divisors.
		# What is the value of the first triangle number to have over five hundred divisors? */


		public static void TriangleNumbers()
		{
			int sum = 0;
			int N = 1000000;
			int count = 0;

			for (int n = 1; n <= N; n++)
			{
				sum = sum + n;

				for (int m = 1; m <= N; m++)
				{
					if (sum % m == 0)
					{
						if (m == 1)
						{
							count = 1;
						}
						else
						{
							count = count + 1;

							if (count == 501)
							{
								Console.WriteLine(sum);
							}
							else
							{

							}
						}
					}
				}
			}
		}
	}
}
