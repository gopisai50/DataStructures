using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class BinaryTree
    {
        
        public static void main(string[] args)
        {

            
            //tree bst = new tree();
            //bst.insert(10);
            //bst.insert(1);
            //bst.insert(9);
            //bst.insert(20);
            //bst.insert(5);
            //bst.insert(30);
            //bst.insert(6);
            //bool result = bst.search(bst.returnroot(),0);
            //Console.Write(result);
            //Console.ReadKey();

        }
    }

    //public class node
    //{
    //    public int item;
    //    public node left;
    //    public node right;

    //}

    //public class tree
    //{
    //    public node root = new node();

    //    public tree()
    //    {
    //        root = null;

    //    }
    //    public node returnroot()
    //    {
    //        return root;

    //    }

    //    public void insert(int id)
    //    {
    //        node newnode = new node();
    //        newnode.item = id;

    //        if (root == null)
    //        {
    //            root = newnode;
    //        }
    //        else
    //        {

    //            node currentNode;
    //            currentNode = root;
    //            while (true)
    //            {


    //                if (id < currentNode.item)
    //                {
    //                    if (currentNode.left == null)
    //                    {
    //                        currentNode.left = newnode;
    //                        return;
    //                    }
    //                    currentNode = currentNode.left;


    //                }
    //                else
    //                {
    //                    if (id > currentNode.item)
    //                    {


    //                        if (currentNode.right == null)
    //                        {
    //                            currentNode.right = newnode;
    //                            return;
    //                        }
    //                        currentNode = currentNode.right;


    //                    }
    //                }


    //            }

    //        }
    //    }

    //    public void inorder(node root)
    //    {
    //        if (root != null)
    //        {
    //            inorder(root.left);
    //            Console.WriteLine(root.item);
    //            inorder(root.right);
    //        }
    //    }
    //    public void preorder(node root)
    //    {
    //        if (root != null)
    //        {
    //            Console.WriteLine(root.item);
    //            preorder(root.left);
    //            preorder(root.right);

    //        }
    //    }
    //    public void postorder(node root)
    //    {
    //        if(root!=null)
    //        {
    //            postorder(root.left);
    //            postorder(root.right);
    //            Console.WriteLine(root.item);
    //        }

    //    }

    //    public bool search(node root, int id)
    //    {
    //        node curentnode = new node();
    //        curentnode = root;
    //        while(true)
    //        {
    //            if (id == curentnode.item)
    //                return true;
    //            else if (id < curentnode.item)
    //            {
    //                if (curentnode.left != null)
    //                    curentnode = curentnode.left;
    //                else
    //                    return false;

    //            }
    //            else
    //            {
    //                if (curentnode.right != null)
    //                    curentnode = curentnode.right;
    //                else
    //                    return false;

    //            }


    //        }
    //    }


    //}

}


