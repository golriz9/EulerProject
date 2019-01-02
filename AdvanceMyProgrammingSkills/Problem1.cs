using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceMyProgrammingSkills
{
	class Problem1
	{
		// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of 
		// these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.

		public static void SumMultipliers()
		{
			
			//int x = 20 % 5;  // output = 0
			//int x = 5 % 20;  // output = 5

			int x = 1;
			int sum = 0;
			while (x < 1000)
			{
				if ((x % 5 == 0) || (x % 3 == 0))
				{
					sum = sum + x;
				}

				x++;
			}

			Console.WriteLine(sum);

		}

	}
}
