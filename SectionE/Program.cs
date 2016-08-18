using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionE
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1_1();
            //q1_2();
            //q2();
            //q3();
            //q4();
            q5();
            //q6();
        }
        static void q1_1()
        {
            Console.WriteLine("increment:");
            Console.Write("Insert a number:");
            string input = Console.ReadLine();
            double n = Convert.ToDouble(input);
            Console.Write("the factorial is:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + "  ");
            }
        }
        static void q1_2()
        {
            Console.WriteLine("decrement:");
            Console.Write("Insert a number:");
            string input = Console.ReadLine();
            double n = Convert.ToDouble(input);
            Console.Write("the factorial is:");
            for (int i = (int)n; i >= 1; i--)
            {
                Console.Write(i + "  ");
            }
        }
        static void q2()
        {

            Console.WriteLine("NO\t      INVERSE\t      SQUARE ROOT      SQUARE");
            Console.WriteLine("------------------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                double sq = Math.Sqrt(i);
                Console.WriteLine("{0:0.0}" + "\t \t" + "{1:0.0##}" + "\t \t" + "{2:0.0##}" + "\t \t" + "{3:0.0##}" + "\t\t\t ", i, 1.0 / i, sq, i * i);
            }

        }
        static void q3()
        {
            Console.Write("Insert a number:");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
        }
        static void q4()
        {
            Console.Write("Insert a number:");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == n)
            {
                Console.WriteLine("It's a perfect number");
            }else
            {
                Console.WriteLine("It's not a perfect number");
            }
        }
        static void q5()
        {
            bool isPrime=true;
            for(int j = 5; j <= 10000; j++)
            {
                for (int i = 2; i <= Math.Sqrt(j); i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(j);
                }
                isPrime = true;
            }
        }
        static void q6()
        {
            int sum = 0;
            bool isPerfect = false;
            for (int j = 1; j < 1000;  j++)
            {
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == j)
                {
                    isPerfect = true;
                }
                if (isPerfect)
                {
                    Console.WriteLine(j);
                }
                isPerfect = false;
                sum = 0;
            }
           
        }
    }
}
