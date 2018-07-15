using System;
using System.Text;

namespace DataStructure
{
    class MainClass
    {
        //public delegate int TestDelegate(int a, int b);

        public static void Main(string[] args)
        {
            // 

            BSTNode node = new BSTNode(7);

            BinarySerachTree bst = new BinarySerachTree();
            bst.root = node;
            //binarySerachTree.InsertNode_Recursive(binarySerachTree.root, 7);
            bst.InsertNode_Recursive(bst.root, 5);
            bst.InsertNode_Recursive(bst.root, 9);
            bst.InsertNode_Recursive(bst.root, 4);
            bst.InsertNode_Recursive(bst.root, 12);
            bst.InsertNode_Recursive(bst.root, 2);
            bst.InsertNode_Recursive(bst.root, 15);
            bst.InsertNode_Recursive(bst.root, 10);



            //bst.InOrder(bst.root);
            //bst.DeleteNode(bst.root, 2);
            //Console.WriteLine();
            //Console.WriteLine("----After deleting node 2----");
            //bst.InOrder(bst.root);
            //bst.DeleteNode(bst.root, 12);
            //Console.WriteLine();
            //Console.WriteLine("----After deleting node 12----");
            //bst.InOrder(bst.root);
            //bst.DeleteNode(bst.root, 7);
            //Console.WriteLine();
            //Console.WriteLine("----After deleting node 7----");
            //bst.InOrder(bst.root);

            //bst.DeleteNode(bst.root, 15);
            //Console.WriteLine();
            //Console.WriteLine("----After deleting node 15----");
            //bst.InOrder(bst.root);


            //Console.WriteLine();
            //Console.WriteLine("----Inorder Successor of node 9----");
            //var curr_node = bst.InOrderSuccessor(bst.root, 9);
            //Console.WriteLine(curr_node.data);

            //Console.WriteLine();
            //Console.WriteLine("----Inorder Successor of node 4----");
            //curr_node = bst.InOrderSuccessor(bst.root, 4);
            //Console.WriteLine(curr_node.data);

            //Console.WriteLine();
            //Console.WriteLine("----Inorder Successor of node 12----");
            //curr_node = bst.InOrderSuccessor(bst.root, 12);
            //Console.WriteLine(curr_node.data);






            //AddTwoNumbers






            // Console.WriteLine("Hello World!");
            Node myNode = new Node(2);
            LinkedList lst = new LinkedList();
            lst.head = myNode;

            lst.AddToEnd(4);
            lst.AddToEnd(3);
            lst.AddToEnd(5);
            lst.AddToEnd(6);
            lst.AddToEnd(7);
            lst.AddToEnd(8);

            Node myNode2 = new Node(5);
            LinkedList lst2 = new LinkedList();
            lst2.head = myNode2;

            lst2.AddToEnd(6);
            lst2.AddToEnd(4);
            lst2.AddToEnd(9);
            lst2.AddToEnd(6);
            lst2.AddToEnd(5);
            lst2.AddToEnd(4);


            var newNode = AddTwoNumbers(myNode, myNode2);
            LinkedList lst3 = new LinkedList();
            lst3.head = newNode;

            lst3.Print();




            //var n = Convert.ToInt32(Console.ReadLine());
            //var arr = new int[n];
            //for (int i = 0; i < n;i++)
            //{
            //    arr[i]= Convert.ToInt32(Console.ReadLine());
            //}

            //var newarr = InsertionSort(arr);

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(newarr[i]);
            //}




            //LinkedList list = new LinkedList();

            //list.AddToBeginning(1);
            //list.AddToBeginning(2);
            //list.AddToBeginning(3);
            //list.AddToBeginning(4);
            //list.AddToBeginning(5);
            //list.AddToBeginning(8);
            //list.AddToEnd(6);
            //list.AddToEnd(7);
            //list.AddToBeginning(9);
            //list.AddToBeginning(10);
            //list.AddToEnd(12);
            //list.AddToEnd(13);
            ////list.AddAfterANode()

            //list.Print();
            //list.PrintLast();
            //list.DeleteLast();
            //list.Print();
            //Console.WriteLine("");
            //list.AddToEnd(14);
            //list.Print();

            //list.DeleteFirst();
            //Console.WriteLine("");
            //list.Print();
            ////list.PrintHead();

            //list.ReverseList();
            //Console.WriteLine("");
            //Console.WriteLine("---------------");
            //list.Print();
            //Console.WriteLine("");
            //Console.WriteLine("---------------");
            //list.ReversePrint(list.head);

            //Console.WriteLine("");
            //Console.WriteLine("----Reversing the list using recursion-----------");
            //list.ReverseList_Recursion(list.head);
            //list.Print();


            //////////////////////
            /// 
            //Console.WriteLine("Enter Jagged Array Length");

            //var n = Convert.ToInt32(Console.ReadLine());

            //int[][] arrays = new int[n][];

            //for (int i = 0; i <= n-1;i++)
            //{

            //    Console.WriteLine("Enter " + i +" Jagged SubArray Length");
            //    var l = Convert.ToInt32(Console.ReadLine());
            //    arrays[i] = new int[l];
            //    for (int j = 0; j <= l-1;j++)
            //    {
            //        arrays[i][j]= Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arrays.Length;i++)
            ////foreach(var array in arrays)
            //{
            //    for (int j = 0; j < arrays[i].Length;j++)
            //    {
            //        Console.WriteLine(arrays[i][j]);
            //    }
            //}



        }

        //public static Node AddNewNode(LinkedList lst, int data)
        //{
        //    var newNode = new Node(data);
        //    newNode.next = null;
        //    lst.head.next = newNode;
        //    return newNode;
        //}


        //public static int[] InsertionSort(int[] arr)
        //{
        //    for (int i = 1; i < arr.Length- 1;i++)
        //    {
        //        var key = arr[i];
        //        for (int j = i-1; j >= 0; j--)
        //        {
        //            if (arr[j] > key)
        //            {
        //                arr[j + 1] = arr[j];
        //                arr[j] = key;
        //            }
        //            else break;
        //        }
        //    }
        //    return arr;
        //}

        public static Node AddTwoNumbers(Node l1, Node l2)
        {

            var num1 = new StringBuilder();
            var num2 = new StringBuilder();
            while (l1 != null)
            {
                num1.Append(l1.data.ToString());
                l1 = l1.next;
            }
            while (l2 != null)
            {
                num2.Append(l2.data.ToString());
                l2 = l2.next;
            }

            var rev_str1 = MainClass.ReverseString(num1.ToString());
            var rev_str2 = MainClass.ReverseString(num2.ToString());
            var num = Convert.ToInt32(rev_str1) + Convert.ToInt32(rev_str2);

            var len = num.ToString().Length;

            var temp_str = num.ToString();
            var node = new Node(Convert.ToInt32(Char.GetNumericValue(Convert.ToChar(temp_str[len - 1]))));
            var list = new LinkedList();
            list.head = node;
            var current = list.head;
            for (int i = len - 2; i >= 0; i--)
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(Convert.ToInt32(Char.GetNumericValue(temp_str[i])));
            }
            list.head.next = current;
            return list.head;
        }

        public static string ReverseString(string str)
        {
            
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
    }
}


