using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask
{
    public struct Employee
    {
        public int id;
        public string name;
        public string surname;
        public string position;
        public int bornYear;
        public double salary;

        public Employee(int id, string name, string surname, string position, int year, double salary)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.bornYear = year;
            this.salary = salary;
        }
    }

    public class Node
        {
            public Employee data;
            public int height;
            public int key;
            public Node left;
            public Node right;
            public Node(Employee data)
            {
                this.height = 1;
                this.data = data;
                this.key = data.id;
                this.left = null;
                this.right = null;
            }
        }

    public class EmployeesTree
    {       
            public Node root;
            List<Employee> resultList = new List<Employee>();

            public void Add(Employee newEmployee)
            {
                Node newNode = new Node(newEmployee);
                if (this.root == null)
                {
                    root = newNode;
                }
                else
                    Insert(root, newNode);
            }

            private Node Insert(Node currentNode, Node insertNode)
            {
                if (currentNode == null)
                {
                    currentNode = insertNode;
                    return currentNode;
                }
                  
                if (insertNode.key < currentNode.key)
                        currentNode.left = Insert(currentNode.left, insertNode);
                else 
                    currentNode.right = Insert(currentNode.right, insertNode);
                    
                return BalanceTree(currentNode);
            }


            public int GetBalanceFactor(Node currentNode)
            {
                int leftHeight, rightHeight, balanceFactor = 0;
            if ((currentNode.left != null) && (currentNode.right != null))
            {
                leftHeight = GetHeight(currentNode.left);
                rightHeight = GetHeight(currentNode.right);
                balanceFactor = leftHeight - rightHeight;
            }
                return balanceFactor;
            }

            private int GetHeight(Node current)
            {
                int height = 0, leftHeight, rightHeight, maxHeight;
                if (current != null)
                {
                    leftHeight = GetHeight(current.left);
                    rightHeight = GetHeight(current.right);

                if (leftHeight > rightHeight)
                    maxHeight = leftHeight;
                else maxHeight = rightHeight;
                
                height = maxHeight + 1;
                }
            return height;
            }

        public void FixHeight(Node currentNode)
        {
            int leftHeight, rightHeight;

            leftHeight = GetHeight(currentNode.left);
            rightHeight = GetHeight(currentNode.right);
            currentNode.height = (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
        }

        public Node BalanceTree(Node currentNode)
           {
            FixHeight(currentNode);
            if (GetBalanceFactor(currentNode) == 2)
            {
                if (GetBalanceFactor(currentNode.right) < 0)
                    currentNode.right = RotateRight(currentNode.right);
                return RotateLeft(currentNode);
            }
            if (GetBalanceFactor(currentNode) == -2)
            {
                if (GetBalanceFactor(currentNode.left) > 0)
                    currentNode.left = RotateLeft(currentNode.left);
                return RotateRight(currentNode);
            }
            return currentNode; 
        }

        public void Delete(int target)
        {
            root = Delete(root, target);
        }

        private Node Delete(Node currentNode, int target)
        {
            Node parent;
            if (currentNode == null)
                return null;
            else
            {
                //left subtree
                if (target < currentNode.key)
                {
                    currentNode.left = Delete(currentNode.left, target);
                    if (GetBalanceFactor(currentNode) == -2)
                    {
                        if (GetBalanceFactor(currentNode.right) <= 0)
                            currentNode = RotateRight(currentNode);
                        else
                        {
                            currentNode = RotateRightLeft(currentNode);
                        }
                    }
                }
                //right subtree
                else if (target > currentNode.key)
                {
                    currentNode.right = Delete(currentNode.right, target);
                    if (GetBalanceFactor(currentNode) == 2)
                    {
                        if (GetBalanceFactor(currentNode.left) >= 0)
                        {
                            currentNode = RotateLeft(currentNode);
                        }
                        else
                        {
                            currentNode = RotateLeftRight(currentNode);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (currentNode.right != null)
                    {
                        //delete its inorder successor
                        parent = currentNode.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        currentNode.key = parent.key;
                        currentNode.right = Delete(currentNode.right, parent.key);
                        if (GetBalanceFactor(currentNode) == 2)//rebalancing
                        {
                            if (GetBalanceFactor(currentNode.left) >= 0)
                                currentNode = RotateLeft(currentNode);
                            else
                                currentNode = RotateLeftRight(currentNode); 
                        }
                    }
                    else
                    {   //if current.left != null
                        return currentNode.left;
                    }
                }
            }
            return currentNode;
        }


        public Node RotateLeft(Node parent)
            {

            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;

            FixHeight(parent);
            FixHeight(pivot);

            return pivot;
        }

        public Node RotateRight(Node parent)
            {
                Node pivot = parent.left;
                parent.left = pivot.right;
                pivot.right = parent;

                FixHeight(parent);
                FixHeight(pivot);

                return pivot;
            }

        private Node RotateLeftRight(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateLeft(pivot);
            return RotateRight(parent);
        }

        private Node RotateRightLeft(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateRight(pivot);
            return RotateLeft(parent);
        }

        public void Find(string position, EmployeesTree positionTree)
        {
            Find(root, position, positionTree);
        }

        

        public void Find(Node currentNode, string position, EmployeesTree positionTree)
        {
            if (currentNode == null)
                return;
            if (currentNode.data.position == position)
                positionTree.Add(currentNode.data);              
            Find(currentNode.left, position, positionTree);
            Find(currentNode.right, position, positionTree);
        }

    }
}
