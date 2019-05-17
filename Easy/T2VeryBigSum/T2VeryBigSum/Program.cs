namespace T2VeryBigSum
{
    using System.IO;
    using System;

    public class Solution
    {

        // Complete the aVeryBigSum function below.
        public static long AVeryBigSum()
        {

        }

        private static void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            var arCount = Convert.ToInt32(Console.ReadLine());
            var ar = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
            var result = AVeryBigSum(ar);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }

}
