using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMyProgrammingSkills
{
	public static class AmazonProblem1
	{
		public static List<List<int>> nearestXsteakHouses(int totalSteakhouses,
													int[,] allLocations,
													int numSteakhouses)
		{
			double[] D = new double[totalSteakhouses];

			List<List<int>> output = new List<List<int>>();

			int[,] temp = new int[totalSteakhouses, 2];

			for (int i = 0; i < totalSteakhouses; i++)
			{
				//D[i] = Math.Pow(Math.Pow(allLocations[1, i], 2) + Math.Pow(allLocations[2, i], 2), 0.5);

				//var last = allLocations.Last();
				//var first = stringArray.First();

				//double x1 = Math.Pow(allLocations[i, 0], 2);
				int x1 = allLocations[i, 0] * allLocations[i, 0];
				//double x2 = Math.Pow(allLocations[i, 1], 2);
				int x2 = allLocations[i, 1] * allLocations[i, 1];
				int x3 = x1 + x2;
				//D = new List<double>
				//{
				//	Math.Sqrt(x3),
				//};

				D[i] = Math.Sqrt(x3);
			}

			for (int i = 0; i < numSteakhouses; i++)
			{
				double[] MinDis;
				double minValue = D.Min();
				int minIndex = D.ToList().IndexOf(minValue);

				output.Add(new List<int> { allLocations[minIndex, 0], allLocations[minIndex, 1] });


				//D_list.RemoveAt(minIndex);
				//listAllLocations.RemoveAt(minIndex);
				D = RemoveAt(D, minIndex);
				for (int j = 0; j <= numSteakhouses - 1; j++)
				{
					if (j != minIndex)
					{
						temp[j, 0] = allLocations[j, 0];
						temp[j, 1] = allLocations[j, 1];
					}
				}

				allLocations = temp;

			}

			return output;
		}


		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return arr.Where((e, i) => i != index).ToArray();
		}
	}
}