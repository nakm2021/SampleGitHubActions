using System;
using System.Collections.Generic;

namespace SampleGitHubActions.Main
{
    public static class Program
    {
        public static List<int> MyList { get; private set; } = new List<int>();

        public static int MyNumber { get; private set; } = 0;

        static Program()
        {
            for (int i = 0; i < 10; i++)
            {
                MyList.Add(i);
            }

            MyNumber = 999;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Test Project");
            Console.ReadKey();
        }
    }
}
