using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using winform_test;

namespace CuoiKy
{
    internal class Program
    {
        public class Account
        {
            public string username { get; set; }
            public string password { get; set; }
            public string fullname { get; set; }
            public string sex { get; set; }
            public int id { get; set; }
            public int age { get; set; }

            public Account()
            {
                this.username = null; this.password = null; this.sex = null; this.id = 0; this.age = 0; this.fullname = null;
            }
            public Account(string user, string pass, string fullname, string sex, int id, int age)
            {
                this.username = user; this.password = pass; this.fullname = fullname;
                this.sex = sex; this.id = id; this.age = age;

            }
            
        }

        public class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public Account Data { get; set; }
        }
        public class BinarySearchTree
        {
            public Node root { get; set; }
            public bool Insert(Account account)
            {
                Node before = null, after = this.root;
                while (after != null)
                {
                    before = after;
                    if (account.id < after.Data.id)
                        after = after.LeftNode;
                    else if (account.id > after.Data.id)
                    {
                        after = after.RightNode;
                    }
                    else
                        return false;
                }
                Node newNode = new Node();
                newNode.Data = account;
                if (this.root == null)
                    this.root = newNode;
                else
                {
                    if (account.id < before.Data.id)
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode;
                }
                return true;
            }
            
            public Account SearchByUser(string username)
            {
                return SearchByUser(root, username);
            }

            private Account SearchByUser(Node node, string username)
            {
                if (node == null)
                    return null;

                if (node.Data.username == username)
                    return node.Data;
                else if (string.Compare(username, node.Data.username) < 0)
                    return SearchByUser(node.LeftNode, username);
                else
                    return SearchByUser(node.RightNode, username);
            }

            public Account SearchById(int id)
            {
                return SearchById(root, id);
            }

            private Account SearchById(Node node, int id)
            {
                if (node == null)
                    return null;

                if (node.Data.id == id)
                    return node.Data;
                else if (id < node.Data.id)
                    return SearchById(node.LeftNode, id);
                else
                    return SearchById(node.RightNode, id);
            }

            //public void TraverseInOrder(Node parent)
            //{
            //    if (parent != null)
            //    {
            //        TraverseInOrder(parent.LeftNode);
            //        Console.Write(parent.Data + "\n");
            //        TraverseInOrder(parent.RightNode);
            //    }
            //}
        }
        
    }
}