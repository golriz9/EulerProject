using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	class PrimeNum
	{
		public Boolean IsPrime(int N) //, int target)
		{
			//int count = 0;
			//int[] p = new int[target];

			if (N % 2 == 1)
			{
				for (int i = 3; i <= Math.Sqrt(N); i += 2)
				{
					if (N % i != 0)
					{
						//p[count] = N;
						//count++;
					}
					else
					{
						return false;
					}
				}
				return true;
			}
			else if (N == 2)
			{
				//p[count] = N;
				return true;
			}
			else
			{
				return false;
			}			
		}
	}
}
