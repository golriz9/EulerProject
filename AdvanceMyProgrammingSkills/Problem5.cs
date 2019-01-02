using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. 
	// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

	class Problem5
	{
		public static void DivisibleProblem()
		{
			double x = Math.Pow(2,4) * 5 * Math.Pow(3,2) * 7 * 11 * 13 * 17 * 19;
			Console.WriteLine(x);
		}
	}
}
