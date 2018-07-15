using System;
namespace DataStructure
{
    public class BinarySerachTree
    {
        public BSTNode root;
        public BinarySerachTree()        
        {
            root = null;
        }

        public void InsertNode( int data)
        {
            if(root==null)
            {
                root = new BSTNode(data);
                return;
            }

            var current = root;
            var isAdded = false;

            while(!isAdded)
            {
                if(data > current.data)
                {
                    if(current.rightNode==null)
                    {
                        current.rightNode = new BSTNode(data);
                        isAdded = true;
                        return;
                    }
                    else 
                    {
                        current = current.rightNode;
                    }
                }
                else if (data<=current.data)
                {
                    if (current.leftNode == null)
                    {
                        current.leftNode = new BSTNode(data);
                        isAdded = true;
                        return;
                    }
                    else
                    {
                        current = current.leftNode;
                    }
                }
            }
        }

        /// <summary>
        /// Inserts the node recursively.
        /// </summary>
        /// <returns>The node recursive.</returns>
        /// <param name="node">Node.</param>
        /// <param name="data">Data.</param>
        public BSTNode InsertNode_Recursive(BSTNode node, int data)
        {
            if (node == null)
            {
                node = new BSTNode(data);
                return node;
            }
            else if(data>node.data)
            {
                node.rightNode= InsertNode_Recursive(node.rightNode, data);
                //return node.rightNode;
            }
            else 
            {
                node.leftNode=InsertNode_Recursive(node.leftNode, data);
                //return node.leftNode;
            }
            return node;

        }

        /// <summary>
        /// Ins the order.
        /// </summary>
        /// <param name="node">Node.</param>
        public void InOrder(BSTNode node)
        {
            if (node == null)
                return;
            InOrder(node.leftNode);
            Console.Write(node.data + "--> ");
            InOrder(node.rightNode);
        }


        /// <summary>
        ///  Method to find the min node in a BST
        /// </summary>
        /// <returns>The minimum.</returns>
        /// <param name="node">Node.</param>
        public BSTNode FindMin(BSTNode node)
        {
            if (node == null) return null;
            while(node.leftNode !=null)
            {
                node = node.leftNode;
            }
            return node;
        }


        /// <summary>
        /// Finds the minimum.
        /// </summary>
        /// <returns>The minimum.</returns>
        /// <param name="node">Node.</param>
        public BSTNode FindMin_Recursively(BSTNode node)
        {
            if (node == null) return null;

            else if(node.leftNode==null)
            {
                return node;
            }
            else
            {
                return FindMin_Recursively(node.leftNode);
            }
        }


        /// <summary>
        /// Deletes the node.
        /// </summary>
        /// <returns>The node.</returns>
        /// <param name="node">Node.</param>
        /// <param name="data">Data.</param>
        public BSTNode DeleteNode (BSTNode node, int data)
        {
            if (node == null)
                return node;
            
            if(data>node.data)
            {
                node.rightNode = DeleteNode(node.rightNode, data);
            }
            else if (data < node.data)
            {
                node.leftNode = DeleteNode(node.leftNode, data);
            }
            else
            {
                if(node.leftNode==null && node.rightNode==null)
                {
                    node = null;
                }
                else if(node.rightNode==null)
                {
                    return node.leftNode;
                }
                else if(node.leftNode==null)
                {
                    return node.rightNode;
                }
                else
                {
                    var temp = FindMin(node.rightNode);
                    node.data = temp.data;
                    node.rightNode = DeleteNode(node.rightNode, temp.data);
                    return node;
                }
            }
            return node;
        }

        /// <summary>
        /// Find the node corresponding to data.
        /// </summary>
        /// <returns>The find.</returns>
        /// <param name="root">Root.</param>
        /// <param name="data">Data.</param>
        public BSTNode Find(BSTNode root, int data)
        {
            if (root == null)
            {
                return null;
            }
            if(data == root.data)
            {
                return root;
            }
            else if (data < root.data)
            {
                return Find(root.leftNode, data);
            }
            else return Find(root.rightNode, data);
        }


        /// <summary>
        /// Finds the inorder successor node of node corresponding to data
        /// </summary>
        /// <returns>The order successor.</returns>
        /// <param name="root">Root.</param>
        /// <param name="data">Data.</param>
        public BSTNode InOrderSuccessor(BSTNode root, int data)
        {
            // Search the node
            var current = Find(root, data);

            // Case 2. When node has right sub tree
            if(current.rightNode !=null)
            {
                var temp = current.rightNode;
                while(temp.leftNode !=null)
                {
                    temp = temp.leftNode;
                }
                return temp;
            }

            //Case 3. When node has no right sub tree. In this case we will have to find the deepest ancestor for which 
            // current node will be in left subtree.
            else 
            {
                BSTNode successor = null;
                var ancestor = root;

                while(ancestor!=current)
                {
                    if (ancestor.data > current.data)
                    {
                        successor = ancestor;
                        ancestor = ancestor.leftNode;
                    }
                    else ancestor = ancestor.rightNode;
                }
                return successor;

            }

            
        }

    }
}
