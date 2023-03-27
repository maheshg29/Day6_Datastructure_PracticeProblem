using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Datastructure_PracticeProblem
{
    public class BuiltInLinklist
    {
        public static void LinkList()
        {
            LinkedList<int> linkListData = new LinkedList<int>();
            // Create operation
            linkListData.AddFirst(999);
            linkListData.AddFirst(2020);
            linkListData.AddLast(10200);
            Console.WriteLine("Current items in list:");
            
            // Read operation
            foreach (int data in linkListData)
            {
                Console.WriteLine(data);
            }

            // Update operation
            LinkedListNode<int> node = linkListData.Find(10200);
            if (node != null)
            {
                node.Value = 1020;
            }
            Console.WriteLine("After Update Element");
            foreach (int data in linkListData)
            {
                Console.WriteLine(data);
            }

            // Delete operation
            linkListData.RemoveFirst();
            Console.WriteLine("After Removing Element");
            foreach (int data in linkListData)
            {
                Console.WriteLine(data);
            }

        }
    }
}
