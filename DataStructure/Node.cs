using System;
namespace DataStructure
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

        //public void AddToEnd(int data)
        //{
        //    if(next==null)
        //    {
        //        next = new Node(data);
        //    }
        //    else
        //    {
        //        next.AddToEnd(data);
        //    }
        //}

        //public void Print()
        //{
        //    Console.Write("|" + data + " ->");
        //    if(next!=null)
        //    {
        //        next.Print();
        //    }
        //}

        //public override string ToString()
        //{
        //    return data.ToString();
        //}
    }
}
