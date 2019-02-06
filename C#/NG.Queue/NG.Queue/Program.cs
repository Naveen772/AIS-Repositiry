using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.Queue
{
    class Program
    {
        
        int front = 0;
        //int rear = 0;
        List<int> QueueList = new List<int>();


        public void Enqueue(int item)
        {
            if (front == 0)                             //checking if queue is empty or not
            {
                front = item;
                QueueList.Add(item);                   //Ading item into queue
                Print();

            }
            else
            {
                QueueList.Add(item);
                Print();
            }
        }


        public void Dequeue()
        {
            if (front == 0)
            {
                Console.WriteLine("Queue is Empty");
                Print();
            }
            else
            {   if (QueueList.Count == 1)
                {
                    QueueList.Remove(front);
                    front = 0;
                }
                else
                {
                    QueueList.Remove(front);

                    front = QueueList.ElementAt(0);
                   
                }
                Print();
            }
        }



        public void Print()
        {
            if (front == 0)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                Console.WriteLine("Queue is:");
                foreach (var variable in QueueList)
                {
                    Console.WriteLine(variable);
                }
            }

        }


        static void Main(string[] args)
        {
            Program pg = new Program();
            while (true)
            {
                Console.WriteLine("Entre Your Choice");
                Console.WriteLine("1 for Enqueue \n2 for Dequeue \n3 for print the queue");
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Entre The Number:");
                            int num = Convert.ToInt32(Console.ReadLine());
                            pg.Enqueue(num);                                //Calling function to enter number in queue
                            Console.WriteLine();
                            break;
                        case 2:
                            pg.Dequeue();                                   //Calling function to remove number in queue
                            break;
                        case 3:
                            pg.Print();
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }
    }

}