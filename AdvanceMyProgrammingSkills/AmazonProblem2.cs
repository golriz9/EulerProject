using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AdvanceMyProgrammingSkills
{
	public static class AmazonProblem2
	{

		public struct AppPairs
		{
			public int xFore, yBack, totalMemory;

			public AppPairs(int p1, int p2, int m)
			{
				xFore = p1;
				yBack = p2;
				totalMemory = m;
			}
		}

		//static int[,] theArrayFore = { { 101, 2 }, { 102, 4 }, { 103, 7 } };
		//static int[,] theArrayBack = { { 201, 5 }, { 202, 7 }, { 203, 6 } };

		//static int[,] theArrayFore = { { 101, 2 }, { 102, 4 }, { 103, 7 } };
		//static int[,] theArrayBack = { { 201, 5 }, { 202, 7 } };

		public static List<List<int>> optimizeMemory(int deviceCapacity,
											List<int[,]> foregroundAppList,
											List<int[,]> backgroundAppList)
		{
			List<List<int>> output = new List<List<int>>();
			List<List<int>> tempList1 = new List<List<int>>();
			List<List<int>> tempList2 = new List<List<int>>();
			AppPairs applicPairs;
			List<AppPairs> AppPairList = new List<AppPairs>();


			for (int i0 = 0; i0 < foregroundAppList.Count; i0++)
			{
				int[,] temp0 = foregroundAppList[i0];
				for (int item0 = 0; item0 < temp0.Length / 2; item0++)
				{

					for (int i1 = 0; i1 < backgroundAppList.Count; i1++)
					{
						int[,] temp1 = backgroundAppList[i1];

						for (int item1 = 0; item1 < temp1.Length / 2; item1++)
						{
							int[] D = new int[temp1.Length / 2];

							if (temp0[item0, 1] + temp1[item1, 1] <= deviceCapacity)
							{
								tempList1.Add(new List<int> { temp0[item0, 0], temp1[item0, 0] });
								D[item1] = temp0[item0, 1] + temp1[item1, 1];

								applicPairs = new AppPairs(temp0[item0, 0], temp1[item1, 0], temp0[item0, 1] + temp1[item1, 1]);
								AppPairList.Add(applicPairs);
							}
							else
							{

							}
						}
					}
				}
			}

			int[] kk = new int[AppPairList.Count];
			int[] kk2 = new int[AppPairList.Count];

			for (int s = 0; s < AppPairList.Count; s++)
			{
				kk[s] = AppPairList[s].totalMemory;
			}

			int max = kk.Max();
			int maxIndex = kk.ToList().IndexOf(kk.Max());
			output.Add(new List<int> { AppPairList[maxIndex].xFore, AppPairList[maxIndex].yBack });

			kk = kk.RemoveAt1(maxIndex);
			int maxIndex1 = kk.ToList().IndexOf(kk.Max());
			while (max == kk.Max())
			{
				maxIndex1 = kk.ToList().IndexOf(kk.Max());
				output.Add(new List<int> { AppPairList[maxIndex1 + 1].xFore, AppPairList[maxIndex1 + 1].yBack });
				kk = kk.RemoveAt1(maxIndex);
			}
			return output;
		}

		public static T[] RemoveAt1
			<T>(this T[] arr, int index)
		{
			return arr.Where((e, i) => i != index).ToArray();
		}

	}
}