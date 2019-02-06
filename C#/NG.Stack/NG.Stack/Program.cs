using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.Stack
{

    class Program
    {
        static int top =0;
        static int capacity=100;
        static int[] arr= new int[100];

        public static void Push(int number)
        {
            if(top==capacity)                               //Checking if stack is full
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                arr[top++] = number;
                Print();
            }
        }
        public static void Pop()
        {
            if (top == 0)                                   //Checking if stack is wmpty or not
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {

                //Console.WriteLine($"Value pop is :{top}");
                top--;
                Print();

            }

        }
        public static void Print()
        {
            if (top == 0)                                   //Checking if stack is empty or not
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack values are:");
                for (int i = 0; i < top; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Entre Your Choice");
                Console.WriteLine("1 for Push \n2 for pop \n3 for print the stack");
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Entre The Number:");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Push(num);
                            Console.WriteLine();
                            break;
                        case 2:
                            Pop();
                            break;
                        case 3:
                            Print();
                            break;
                    }
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
