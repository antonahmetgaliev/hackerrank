using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace T1ArrayRate
{

    public static class Solution
    {
        // Complete the compareTriplets function below.
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var rate = new List<int>{0,0};
            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) rate[0]++;
                if (a[i] < b[i]) rate[1]++;
            }

            return rate;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            var b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            var result = CompareTriplets(a, b);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}
