using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class fulltree
    {
        public static void main()
        {
            treedemo tre = new treedemo();
            //tre.insert(3);
            //tre.insert(10);
            //tre.insert(1);
            //tre.insert(2);
            //tre.insert(9);
            //tre.inorder(tre.retrunroot());
            //bool check = tre.isbalanced(tre.retrunroot());
            //int i = tre.size(tre.retrunroot());
            int[] ar = new int[] { 1, 2, 3 };
            node2 nosd = tre.ArrtoBst(ar, 0, ar.Length - 1);
        }
    }
    class node2
    {
        public node2 left;
        public node2 right;
        public int item;

        public node2()
        {
            left = null;
            right = null;
            item = 0;

        }
    }

    class treedemo
    {
        int COUNT = 0;
        node2 root;
        public treedemo()
        {
            root = new node2();


        }
        public node2 retrunroot()
        {
            return root;
        }

        public void insert(int data)
        {
            node2 newnode = new node2();
            newnode.item = data;
            if (root.item == 0)
            {
                root = newnode;
            }
            else
            {
                node2 temp = root;
                node2 prev = temp;

                while (true)
                {

                    if (data > temp.item)
                    {
                        prev = temp;
                        temp = temp.right;
                        if (temp == null)
                        {
                            prev.right = newnode;
                            break;
                        }
                    }
                    else
                    {
                        prev = temp;
                        temp = temp.left;
                        if (temp == null)
                        {
                            prev.left = newnode;
                            break;
                        }
                    }
                }


                // OWN SHIT CODE

                //    if (data > root.item)
                //    {
                //        node2 prev = null;
                //        while (temp != null)
                //        {
                //            prev = temp;
                //            if (data > temp.item)
                //            {

                //                temp = temp.right;
                //                if (temp == null)
                //                {
                //                    prev.right = newnode;
                //                }
                //            }
                //            else
                //            {

                //                temp = temp.left;
                //                if (temp == null)
                //                {
                //                    prev.left = newnode;
                //                }
                //            }
                //        }


                //    }
                //    else
                //    {
                //        node2 prev = null;
                //        while (temp != null)
                //        {
                //            prev = temp;
                //            if (data > temp.item)
                //            {

                //                temp = temp.right;
                //                if (temp == null)
                //                {
                //                    prev.right = newnode;
                //                }
                //            }
                //            else
                //            {
                //                temp = temp.left;
                //                if (temp == null)
                //                {
                //                    prev.left = newnode;
                //                }
                //            }
                //        }


                //    }

            }

        }

        public void inorder(node2 root)
        {

            if (root != null)
            {
                inorder(root.left);
                Console.WriteLine(root.item);

                inorder(root.right);

            }
        }

        public bool isbalanced(node2 node)
        {

            if (node == null)
            {
                return true;
            }

            int lh = height(node.left);
            int rh = height(node.right);
            if (Math.Abs(lh - rh) <= 1 && isbalanced(node.left)
                                   && isbalanced(node.right))
            {
                return true;
            }
            return false;



        }

        public int height(node2 node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(height(node.left), height(node.right));

        }


        public int size(node2 node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int i = size(node.left);
                int j = size(node.right);
                return i + j + 1;
            }
        }


        public node2 ArrtoBst(int[] arr, int start, int end)
        {
            if (start > end)
                return null;
            int mid = (start + end) / 2;
            node2 newnode = new node2();
            newnode.item = arr[mid];

            newnode.left = ArrtoBst(arr, start, mid - 1);
            newnode.right = ArrtoBst(arr, mid + 1, end);

            return newnode;


        }
    }
}
