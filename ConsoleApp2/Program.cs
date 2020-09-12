using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=0;i <=4;i++)
            {
                if(i == 3)
                {
                    Console.WriteLine("  valid");
                    Console.WriteLine("Please Proceed next");
                }
                else
                {
                    Console.WriteLine(" not valid");
                }
            }
         
        }
    }
}
