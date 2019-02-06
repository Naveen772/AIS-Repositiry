using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.MergeSort
{
    class Program
    {
        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            String choice = "";
            List<Int32> UnsortedList = new List<Int32>();
            List<int> sorted;
            checkpoint: Console.WriteLine("Enter number of the Element");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                for (int counter = 0; counter < number; counter++)
                {
                    Console.Write($"Enter {counter} element: ");
                    UnsortedList.Add(Convert.ToInt32(Console.ReadLine()));
                }
                sorted = MergeSort(UnsortedList);

                Console.WriteLine("Sorted array elements: ");
                foreach (int x in sorted)
                {
                    Console.Write(x + " ");
                }
                Console.Write("\n");

            }
            catch (System.FormatException)
            {
                Console.WriteLine("invalid input");
                Checkpoint2: Console.WriteLine("Press Y for try again and N for exit ");
                choice = Console.ReadLine();


                if (choice.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                    goto checkpoint;
                else if (choice.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                    System.Environment.Exit(1);
                else
                    goto Checkpoint2;
             }
            Console.ReadKey();
        }
    
        }

    }

