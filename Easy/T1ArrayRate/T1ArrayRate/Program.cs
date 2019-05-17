namespace T1ArrayRate
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System;

    internal class Solution
    {
        // Complete the compareTriplets function below.
        static List<int> CompareTriplets(List<int> a, List<int> b)
        {


        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            var b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            var result = CompareTriplets(a, b);
            textWriter.WriteLine(string.Join(" ", result));
            textWriter.Flush();
            textWriter.Close();
        }
    }

}
