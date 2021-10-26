using System;

namespace baseKatas
{
    class Program
    {
        //Opposites attract: aka numbers and conditionals
        static bool OppositesAttract(int flower1, int flower2)
        {
            return (flower1 % 2 != flower2 % 2);
        }

        //Sum of postives: lists, conditionals, and numbers
        static int SumOfPositives(int[] arr)
        {
            int sum = 0;
            foreach(int number in arr) {
                if(number > 0) 
                    sum+= number;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
