using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	class Problem7
	{
		// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. 
		// What is the 10 001st prime number?

		public static void TenThousandsAndFirstPrime()
		{			
			int target = 10001;
			int count = 0;

			int[] p = new int[target];

			for (int i = 15; count < target - 6; i++)
			{
				// check whether i is odd
				if (i % 2 == 1)
				{
					int d = 3;
					double x = Math.Sqrt(i);

					// check the odd divisors of i as long as they are smaller than square root of i
					while ((d < x) && (i % d != 0))
					{
						d += 2;

						//if (i % d == 0)
						//{
						//	d += 2;
						//}
						//else
						//{
						//	break;
						//}
					}

					if (((i % d != 0) && (i != d)))
					{
						p[count] = i;
						count++;
					}

				}
				
						
				
			}
			Console.WriteLine(p[target-7]);

		}
	}
}
