using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	class Problem3
	{
		// The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143?
		public static void PrimeFactor()
		{
			double x = 0;
			double N = 600851475143;
			double p = 2;
			//int fail = 2;
	
			if (N >= Math.Pow(p, 2))
			{
				if (N % p == 0)
				{
					N = N / p;
				}
				else
				{
					p = p + 1;
				}

				while (N >= Math.Pow(p, 2))
				{
					if (N % p == 0)
					{
						N = N / p;
					}
					else
					{
						p = p + 1;
					}
				}
			}

			x = N;

			Console.WriteLine(x);
		}
	}
}
