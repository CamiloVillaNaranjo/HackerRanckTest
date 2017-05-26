using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakerrank_tests
{
    class Program
    {
        protected Program() { }

        static int solveMyFirst(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
        static void Main(string[] args)
        {
            // Method intentionally left empty.
            /* this is solveMyFirst:
            * int val1 = Convert.ToInt32(Console.ReadLine());
            * int val2 = Convert.ToInt32(Console.ReadLine());
            * int sum = solveMyFirst(val1, val2);
            * Console.WriteLine(sum);
            * Console.ReadKey();
            */

            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //simpleArraySum(n, arr);
            //Console.ReadKey();

            //string[] tokens_a0 = Console.ReadLine().Split(' ');
            //int a0 = Convert.ToInt32(tokens_a0[0]);
            //int a1 = Convert.ToInt32(tokens_a0[1]);
            //int a2 = Convert.ToInt32(tokens_a0[2]);
            //string[] tokens_b0 = Console.ReadLine().Split(' ');
            //int b0 = Convert.ToInt32(tokens_b0[0]);
            //int b1 = Convert.ToInt32(tokens_b0[1]);
            //int b2 = Convert.ToInt32(tokens_b0[2]);
            //int[] result = comparingTriplets(a0, a1, a2, b0, b1, b2);
            //Console.WriteLine(String.Join(" ", result));

            //
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[][] a = new int[n][];
            //for (int a_i = 0; a_i < n; a_i++)
            //{
            //    string[] a_temp = Console.ReadLine().Split(' ');
            //    a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //int k = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(
            //plusMinus(n, arr);
            //stairCase(n);
            //Console.WriteLine(sumOfTwoPairs(arr, k));
            //solvingMinMaxSum(arr);
            //);

            string time = Console.ReadLine();
            Console.WriteLine(timeConversion(time));
            Console.ReadKey();
        }

        private static void simpleArraySum(int n, int[] arr)
        {
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                result += arr[i];
            }
            Console.WriteLine(result);
        }

        private static int[] comparingTriplets(int a0, int a1, int a2, int b0, int b1, int b2){
            int[] result = { 0, 0 };

            if (a0 > b0) result[0] += 1;
            if (a1 > b1) result[0] += 1;
            if (a2 > b2) result[0] += 1;

            if (a0 < b0) result[1] += 1;
            if (a1 < b1) result[1] += 1;
            if (a2 < b2) result[1] += 1;

            return result;
        }

        private static long veryBigSum(int n, int[] arr){
            long result = 0;
            if (1 > n && n > 10) return 0;
            for (int i = 0; i < n; i++)
            {
                if (0 > arr[i] && arr[i] > (Int32)Math.Pow(10,10))
                {
                    return 0;
                }
                result += arr[i];
            }
            return result;
        }

        private static int diagonalDifference(int n, int[][] m)
        {
            int j = m[0].Length;

            int d1, d2;
            d1 = 0;
            d2 = 0;

            for (int i = 0; i < n; i++)
            {
                var a = m[i];
                var b = m[i].Reverse().ToArray();
                for (int k = 0; k < j; k++)
                {
                    if (-100 > a[k] && a[k] > 100)
                        return 0;                                    
                    if (-100 > b[k] && b[k] > 100)
                        return 0;
                    if (i == k) {
                        d1 += a[k];
                        d2 += b[k];
                    }
                }
            }
            int val = d1 - d2;
            return (int)Math.Abs(val);
        }

        private static void plusMinus(int n, int[] arr)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zerosCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0) zerosCount += 1;
                else
                {
                    if (arr[i] < 0) negativeCount += 1;
                    else positiveCount += 1;
                }
            }
            Console.WriteLine(Math.Round(((decimal)positiveCount / n), 6));
            Console.WriteLine(Math.Round(((decimal)negativeCount / n),6));
            Console.WriteLine(Math.Round(((decimal)zerosCount / n),6));
        }

        static void stairCase(int n)
        {   
            for (int i = 0; i < n; i++)
            {
                string str1 = new string(' ', n - (i+1));
                string str2 = new string('#', (i + 1));
                string str3 = string.Concat(str1, str2);
                Console.WriteLine(str3);
            }
        }

        static void solvingMinMaxSum(Int64[] arr)
        {
            int len = arr.Length;
            long total = arr.Sum();
            long max = 0;
            long min = total;
            for (int i = 0; i < len; i++)
            {
                if (max < (total - arr[i])) max = (total - arr[i]);
                if (min > (total - arr[i])) min = (total - arr[i]);
            }

            Console.WriteLine(string.Format("{0} {1}", min, max));
        }

        static int birthdayCakeCandles(int n, int[] arr)
        {
            int tallest = 0;
            int candels = 0;

            tallest = arr.Max();

            if (1 > n && n > (int)Math.Pow(10, 5)) return 0;

            for (int i = 0; i < n; i++)
            {
                if (1 > arr[i] && arr[i] > (int)Math.Pow(10, 7)) return 0;
                if (arr[i] == tallest) candels += 1;
            }

            return candels;
        }

        static int sumOfTwoPairs(int[] a, int k)
        {
            var parList = new List<string>();
            for (int i = 0; i < a.Length; i++)
            {
                if (0 > a[i] && a[i] > (int)Math.Pow(10, 9)) return 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (0 > a[j] && a[j] > (int)Math.Pow(10, 9)) return 0;
                    if (a[i] + a[j] == k)
                    {
                        if(parList.Count == 0)
                            parList.Add(string.Format("{0},{1}", a[i], a[j]));
                        else
                        {
                            string str1 = string.Format("{0},{1}", a[i], a[j]);
                            string str2 = string.Format("{0},{1}", a[j], a[i]);
                            if (!parList.Contains(str1) && !parList.Contains(str2))
                            {
                                parList.Add(str1);
                            }
                        }
                    }
                }
            }
            return parList.Count;
        }

        static string timeConversion(string timeInput)
        {
            DateTime dt;

            if (DateTime.TryParse(timeInput, out dt))
            {
                return dt.TimeOfDay.ToString().Substring(0, 8);
            }
            else
            {
                return "00:00:00";
            }
        }
    }
}
