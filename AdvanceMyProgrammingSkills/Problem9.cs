using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	class Problem9
	{
		/*A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
		a2 + b2 = c2		
		For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

		There exists exactly one Pythagorean triplet for which a + b + c = 1000.
		Find the product abc. */
		
		public static void PythagoreanTriplet()
		{
			int a, b, c;
			int abc = 0;
			for (a = 1; a <= 1000; a++)
			{
				for (b = 1; b <= 1000; b++)
				{
					for (c = 1; c <= 1000; c++)
					{
						if ((a + b + c == 1000) && (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)))
						{							
							abc = a * b * c;							
						}
					}
				}
			}
		}

	}
}
