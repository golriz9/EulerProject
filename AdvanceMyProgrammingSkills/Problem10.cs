using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	class Problem10
	{
		/* The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
		Find the sum of all the primes below two million. */

		public static void PrimeSums()
		{
			int L = 5000000;
			int count = 4;
			int sum = 17;
			int i;
			int[] p = new int[L];
		
			for (i = 11; i <= 2000000; i++)
			{
				PrimeNum f1 = new PrimeNum();
				if ((f1.IsPrime(i)))
				{
					p[count] = i;
					sum = sum + p[count];
					count++;
				}			
			}

			Console.WriteLine(sum);
		}
	}
}