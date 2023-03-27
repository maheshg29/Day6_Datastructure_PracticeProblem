using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Datastructure_PracticeProblem
{
    class CustomeGenericLinkList<T> where T : IComparable<T>
    {
        private Node<T> head;

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into Linklist", head.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into Linklist", newNode.data);
            }
        }

        public void Addfirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Console.WriteLine("{0} is inserted in linklist", newNode.data);
            newNode.next = head;
            head = newNode;
        }

        public void DisplayList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }

        public void Remove(T data)
        {
            if (head == null)
            {
                return;
            }

            if (head.data.Equals(data))
            {
                head = head.next;
                return;
            }

            Node<T> currentNode = head;
            while (currentNode.next != null)
            {
                if (currentNode.next.data.Equals(data))
                {
                    currentNode.next = currentNode.next.next;
                    return;
                }
                currentNode = currentNode.next;
            }
        }

        public void InsertInDescendingOrder(T value)
        {
            Node<T> newNode = new Node<T>(value);

            // If the list is empty, insert the new node at the head
            if (head == null)
            {
                head = newNode;
                return;
            }

            // If the new node should be the new head, insert it at the beginning
            if (value.CompareTo(head.data) > 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
        }
    }
}
