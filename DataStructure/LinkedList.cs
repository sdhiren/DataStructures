using System;
using System.Text;
namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }

        //Add node to end of linked list
        public void AddToEnd(int data)
        {
            if(head == null)
            {
                head = new Node(data);
            }
            else
            {
                //head.AddToEnd(data);
                Node current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
            }           
        }

        //Add node at the beginning
        public void AddToBeginning(int data)
        {
            if(head==null)
            {
                head = new Node(data);
            }
            else
            {
                var newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
        }

        //
        public void AddAfterANode(Node prevnode, int data)
        {
            if(prevnode.next==null){
                return;
            }
            var temp = new Node(data);
            temp.next = prevnode.next;
            prevnode.next = temp;
        }
         
        //Print All Nodes
        public void Print()
        {
            //if(head!=null)
            //{
            //    head.Print();
            //}
            Node current = head;
            while(current != null)
            {                
                Console.Write("|" + current.data + " ->");
                current = current.next;

            }
        }

        //Print Last Node
        public void PrintLast()
        {
            Node current = head;
            while(current.next!=null)
            {
                current = current.next;
            }
            Console.WriteLine("");
            Console.WriteLine(current.data);
        }


        // Delete Last Node
        public void DeleteLast()
        {
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
        }


        // Delete First Node
        public void DeleteFirst()
        {
            Node current = head;
            head = head.next;
            current.next = null;
        }
		
        // Reverses the linked list using iteration
        public void ReverseList()
        {
            var current = head;
            Node previousNode = null;
            Node nextNode = null;
            while(current !=null)
            {
                nextNode = current.next;
                current.next = previousNode;
                previousNode = current;
                current = nextNode;
            }
            head = previousNode;
        }

        // Print the list in reverse order using recursion
        public void ReversePrint(Node head)
        {
              Node current = head;
              if (current == null)
                return;            
            ReversePrint(current.next);
            Console.Write("|" + current.data + " ->");
        }

        // Reversing the list using recursion
        public void ReverseList_Recursion(Node current)
        {
            if (current.next == null)
            {
                head = current;
                return;
            }
            ReverseList_Recursion(current.next);
            Node next = current.next;
            next.next = current;
            current.next = null;
        }
	}
}
    