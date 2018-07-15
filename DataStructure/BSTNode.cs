using System;
namespace DataStructure
{
    public class BSTNode
    {
        public int data;
        public BSTNode leftNode;
        public BSTNode rightNode;
        public BSTNode parentNode;// Added this property to find InOrder Successor 

        public BSTNode(int data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
