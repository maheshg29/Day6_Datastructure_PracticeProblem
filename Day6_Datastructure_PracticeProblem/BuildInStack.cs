using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Datastructure_PracticeProblem
{
    public class BuildInStack
    {
        public static void BuildStack()
        {
            Stack<string> intStack = new Stack<string>();
            // Create operation
            intStack.Push("Mahesh");
            intStack.Push("Gangurde");

            //Read Operation
            Console.WriteLine("Element Present in Stack is \n");
            foreach (var item in intStack)
            {
                Console.WriteLine(item);
            }

            intStack.Push("Akshay");
            Console.WriteLine("Peak Element is "+ intStack.Peek());
            Console.WriteLine("Pop Element "+ intStack.Pop());

            Console.WriteLine("After Pop Operation in Stack \n");
            foreach (var item in intStack)
            {
                Console.WriteLine(item);
            }

            //intStack.Clear();

        }
    }
}
