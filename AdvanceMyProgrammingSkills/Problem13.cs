using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AdvanceMyProgrammingSkills
{
	class Problem13
	{
		// Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

		public static void OneHundredFiftyDigit()
		{
			int count = 0;
			int c = 0;
			double N1 = 0;
			double sum;
			int L = 49;
			int Cnt = 100;
			double[] sumVec = new double[Cnt];
			string[] str_50Dig = new string[100];
			double SUM = 0;
			string text = String.Empty;

			FileStream fs = new FileStream(@"C:\Users\GolrizSedaghat\Desktop\OneHundredFiftyDigitNumber.txt", FileMode.Open, FileAccess.Read);

			string line;
			using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
			{
				while ((line = streamReader.ReadLine()) != null)
				{
					str_50Dig[count] = line;
					count++;
				}
			}

			for (int m = 0; m <= L; m++)
			{
				sum = 0;
				for (int n = 0; n < Cnt; n++)
				{
					string temp = str_50Dig[n];
					N1 = Char.GetNumericValue(temp[L - m]);
					sum = Math.Pow(10, m) * N1 + sum;
				}
				sumVec[m] = sum;
				SUM = sumVec[m] + SUM;
			}

			string str = SUM.ToString();

			Console.WriteLine(SUM);
		}
	}
}



//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;

//namespace AdvanceMyProgrammingSkills
//{
//	class Problem13
//	{
//		// Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

//		public static void OneHundredFiftyDigit()
//		{
//			FileStream fs = new FileStream(@"C:\Users\GolrizSedaghat\Desktop\OneHundredFiftyDigitNumber.txt", FileMode.Open, FileAccess.Read);

//			BigInteger result = new BigInteger();
//			string line;

//			using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
//			{
//				while ((line = streamReader.ReadLine()) != null)
//				{
//					result += BigInteger.Parse(line);
//				}
//			}

//			Console.WriteLine(result);
//		}
//	}
//}
