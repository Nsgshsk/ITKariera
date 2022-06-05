using System.Text;
using System.Diagnostics;
namespace AlgorithmEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            Random r = new Random();
            int[] a = new int[10000];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0, 10);
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubleSortDo(a);
            //bool result = Contains(5, a);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            //Console.WriteLine(result);
        }
        static bool Contains(int x, int[] nums)
        {
            int max = nums.Length - 1;
            int min = 0;
            while (min != max)
            {
                int mid = Convert.ToInt32(Math.Ceiling((double)(min + max) / 2));
                if (x < nums[mid]) max = mid - 1;
                else min = mid;
            }
            if (nums[min] == x) return true;
            return false;

        }
        static string Reapeat(string x, int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(x);
            }
            return stringBuilder.ToString();
        }
        static void BubleSort(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                bool noSwap = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                        noSwap = false;
                    }
                }
                if (noSwap) break;
            }
        }
        static void BubleSortDo(int[] nums)
        {
            bool swap;
            do
            {
                swap = false;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                        swap = true;
                    }
                }
            } while (swap);
        }
    }
}