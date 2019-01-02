using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AdvanceMyProgrammingSkills
{
	public static class ProjectEuler
	{

		//static int[,] theArrayFore = { { 101, 2 }, { 102, 4 }, { 103, 7 } };
		//static int[,] theArrayBack = { { 201, 5 }, { 202, 7 }, { 203, 6 } };

		static int[,] theArrayFore = { { 101, 2 }, { 102, 4 }, { 103, 7 } };
		static int[,] theArrayBack = { { 201, 5 }, { 202, 7 }};
		
		static void Main(string[] args)
		{
			//List<int[,]> forgroundAppList = new List<int[,]>();
			//List<int[,]> backgroundAppList = new List<int[,]>();
			//forgroundAppList.Add(theArrayFore);
			//backgroundAppList.Add(theArrayBack);

			//List<List<int>> output = AmazonProblem2.optimizeMemory(10, forgroundAppList, backgroundAppList);

			//SimpleSum.AddNumbers();
			//Problem1.SumMultipliers();
			//Problem2.Fibonacci();
			//Problem3.PrimeFactor();
			//Problem4.Palindromic();
			//Problem5.DivisibleProblem();
			//Problem6.SumSqureDiff();
			//Problem7.TenThousandsAndFirstPrime();
			//Problem8.ThirteenAdjacentDigitsGreatestProduct();
			//Problem9.PythagoreanTriplet();
			//Problem10.PrimeSums();
			Problem11.TwentyByTwentyGrid();
			//Problem12.TriangleNumbers();
			//Problem13.OneHundredFiftyDigit();
		}
	}
}