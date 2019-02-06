using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG.DFS
{


    class Node
    {
        public int item;
        public Node root;
        public Node right;
        public Node left;


    }
    class DFS
    {
        Queue<Int32> qt = new Queue<Int32>();
        Dictionary<int, Node> MyList = new Dictionary<int, Node>();
        public void DFSInorder(Node root)
        {   
            if(root==null)
            {
                return;
            }

            DFSInorder(root.left);
            Console.WriteLine(root.item);                               //For preorder follow LNR 
            DFSInorder(root.right);


        }
        public void DFSPostorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            
            DFSPostorder(root.left);  
            DFSPostorder(root.right);                                   //For preorder follow LRN 
            Console.WriteLine(root.item);

        }
        public void DFSPreorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.item);

            DFSPostorder(root.left);                                     //For preorder follow NLR 
            DFSPostorder(root.right);



        }

        static void Main(string[] args)
        {
            DFS dfs = new DFS();
            Node myNode1 = new Node();
            Node myNode2 = new Node();
            Node myNode3 = new Node();
            Node myNode4 = new Node();
            Node myNode5 = new Node();
            Node myNode6 = new Node();


            myNode1.root = myNode1;
            myNode1.left = myNode2;
            myNode1.right = myNode3;
            myNode1.item = 5;

            myNode2.root = myNode1;
            myNode2.left = myNode4;
            myNode2.right = myNode5;
            myNode2.item = 3;

            myNode3.root = myNode1;
            myNode3.right = myNode6;
            myNode3.left = null;
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

            
                while (true)
                {
                try
                {
                    Console.WriteLine("1 for Inorder \n2 for Postorder \n3 for Preorder");
                    Console.WriteLine("Entre your Choice");
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Inorrde Traversal");
                            dfs.DFSInorder(myNode1);
                            break;
                        case 2:
                            Console.WriteLine("Preorder Traversal");
                            dfs.DFSPostorder(myNode1);
                            break;
                        case 3:
                            Console.WriteLine("Postorder Traversal");
                            dfs.DFSPreorder(myNode1);
                            break;

                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid Input Format");
                }

                }
            }
            
            

        }
    }

