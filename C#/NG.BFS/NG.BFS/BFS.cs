using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.BFS
{   class node
    {
        public int item;
        public node root;
        public node right;
        public node left;

        
    }
    class BFS
    {
        Queue<Int32> qt = new Queue<Int32>();
        Dictionary<int, node> MyList = new Dictionary< int,node>();
        public void BFSImplement(node root)
        {
            node current = root;
            node left = null;
            node right = null;
            qt.Enqueue(current.item);

            while (qt.Count != 0)
            {
                qt.Dequeue();
                Console.WriteLine(current.item);
                left = current.left;
                right = current.right;


                if (!(left == null))
                {
                    qt.Enqueue(left.item);
                    MyList.Add( left.item,left);
                    
                }


                if (!(right == null))
                {
                    qt.Enqueue(right.item);
                    MyList.Add(right.item,right);
                   

                }
                if(qt.Count()!=0)
                current = MyList[qt.Peek()];

                else
                    break;


            }
        }

            static void Main(string[] args)
        {
            BFS bfs = new BFS();
            node myNode1 = new node();
            node myNode2= new node();
            node myNode3 = new node();
            node myNode4 = new node();
            node myNode5 = new node();
            node myNode6 = new node();

            
            myNode1.root = myNode1;
            myNode1.left = myNode2;
            myNode1.right = myNode3;
            myNode1.item = 5;

            myNode2.root = myNode1;
            myNode2.left = myNode4;
            myNode2.right = myNode5;
            myNode2.item = 3;

            myNode3.root = myNode1;
            myNode3.left = myNode6;
            myNode3.right = null;
            myNode3.item = 7;

            myNode4.root = myNode2;
            myNode4.left = null;
            myNode4.right = null;
            myNode4.item = 1;

            myNode5.root = myNode2;
            myNode5.left = null;
            myNode5.right = null;
            myNode5.item = 2;

            myNode6.root = myNode3;
            myNode6.left = null;
            myNode6.right = null;
            myNode6.item = 6;

            bfs.BFSImplement(myNode1);
            Console.ReadKey();

        }
    }

}