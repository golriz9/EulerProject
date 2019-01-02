using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	class Problem6
	{
		// The sum of the squares of the first ten natural numbers is, 
		// 1^2 + 2^2 + ... + 10^2 = 385 The square of the sum of the first ten natural numbers is, 
		// (1 + 2 + ... + 10)^2 = 55^2 = 3025 
		// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 
		// 3025 − 385 = 2640. Find the difference between the sum of the squares of the first one hundred natural numbers and the 
		// square of the sum. 

		

		public static void SumSqureDiff()
		{
			double sum_sq = 0;
			double sum = 0;

			for (int i=1; i<=100; i++)
			{
				sum_sq = sum_sq + Math.Pow(i, 2);
			}

			for (int i = 1; i <= 100; i++)
			{
				sum = sum + i;
			}

			double x = Math.Pow(sum, 2) - sum_sq;

			Console.WriteLine(x);
		}

	}
}
