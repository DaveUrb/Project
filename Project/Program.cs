using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < ints.Count(); i++)
            {
                ints[i] = random.Next(-10,11);
            }//Generate 10 random numbers
;           
            foreach (int i in ints)
            {
                Console.Write(i+", ");
            }//Print whole array to console
            Console.WriteLine();
            int a = ints[0];
            foreach(int i in ints)//Find the lowest number in array and print it
            {
                if (i < a)
                {
                    a = i;
                }
            }
            Console.WriteLine("Your lowest random number is: "+ a);
            double avg=0, sumArr = 0;
            int smaller = 0, bigger = 0, equal=0;
            foreach(int i in ints)
            {
                sumArr+=i;
            }
            avg = sumArr / ints.Count();
            Console.WriteLine("Sum of your random numbers is: "+ sumArr);
            Console.WriteLine("Average of your random numbers is:"+ avg);
            foreach(int i in ints)
            {
                if (i < avg)
                {
                    smaller++;
                }else if (i > avg)
                {
                    bigger++;
                }
                else
                {
                    equal++;
                }
            }
            Console.WriteLine("There are "+ smaller + " numbers smaller than average.");
            Console.WriteLine("There are "+ bigger + " numbers bigger than average.");
            Console.WriteLine("There are "+ equal + " numbers equal to the average.");
            Console.WriteLine("Array in reversed order:");
            for (int i = ints.Count()-1; i >=0; i--)
            {
                Console.Write(ints[i] + ", ");

            }
            Console.WriteLine("Test environment. Just check the Git changes instantly");

        }
    }
}
