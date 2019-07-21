using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[][] solution;
            solution=getsolution();
            foreach (var item in solution)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1 == 0 ? '-':'Q');
                }
                Console.WriteLine("reut reut");

            }
        
        }
         static int[][] getsolution()
        {
           
            return;
        }
    }
}
