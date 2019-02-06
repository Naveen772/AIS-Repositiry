using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {   while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number of elements");
                    int lenght = Convert.ToInt32(Console.ReadLine());
                    int[] inputArray = new int[lenght];
                    for (int counter = 0; counter < lenght; counter++)
                    {
                        Console.WriteLine($"Enter the value of {counter}:");
                        inputArray[counter] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Unsorted Array ");
                    foreach (var variable in inputArray)
                    {

                        Console.WriteLine(variable);
                    }
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            if (inputArray[j - 1] > inputArray[j])
                            {
                                int temp = inputArray[j - 1];
                                inputArray[j - 1] = inputArray[j];
                                inputArray[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Sorted Array ");
                    foreach (var variable in inputArray)
                    {

                        Console.WriteLine(variable);
                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Wrong format of input");
                }
            }
            //Console.ReadKey();
        }
    }
}
