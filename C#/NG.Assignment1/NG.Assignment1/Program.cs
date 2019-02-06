using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.Assignment1
{
    class Program
    {
         public static bool Prime(int num)
        {
            bool flag = false;
            if(num==1)
            {
                flag = true;
                return flag;
            }
            for(int i=2;i<num/2;i++)
            {
                if(num%i==0)
                {
                    flag=true;
                    break;
                }
             }
            return flag;

        }
        public static void Fibonacci(int num)
        {
            int firstnum = 0;
            int secondnum = 1;
            Console.WriteLine(firstnum);
            Console.WriteLine(secondnum);
            for (int i = 2; i < num; i++)
            {
                int temp = firstnum + secondnum;
                firstnum = secondnum;
                secondnum = temp;

                if (!(Prime(temp)))
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine(temp);

            }
        }
        static void Main(string[] args)
        {
            int length=0;
            try
            {
                Console.WriteLine("Entre the length of the fibonacci series:");
                length = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                 Console.WriteLine("Please give valid input");
            }
           
            Fibonacci(length);
            Console.ReadKey();
            
        }
    }
}
