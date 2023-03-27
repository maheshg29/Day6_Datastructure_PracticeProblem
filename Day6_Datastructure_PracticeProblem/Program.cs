using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Datastructure_PracticeProblem
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day6 Datastructure PracticeProblem");
            Console.WriteLine("Select any one option for \n 1. Generic Custom Linklist \n 2. GenericStack" +
                "\n 3. Generic Custom Queue \n 4. Buil-In LinkList \n 5. Build_In Stack \n 6. Build_In Queue");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    CustomeGenericLinkList<int> integerLinkList = new CustomeGenericLinkList<int>();
                    integerLinkList.AddLast(10);
                    integerLinkList.AddLast(20);
                    integerLinkList.Addfirst(30);
                    integerLinkList.Addfirst(40);
                    integerLinkList.DisplayList();

                    CustomeGenericLinkList<string> stringLinkList = new CustomeGenericLinkList<string>();
                    stringLinkList.AddLast("mahesh");
                    stringLinkList.Addfirst("Gangurde");
                    stringLinkList.DisplayList();
                    Console.WriteLine("after removing Element");
                    stringLinkList.Remove("Gangurde");
                    stringLinkList.DisplayList();
                    break;
                case 2:
                    GenericStack<int> integerStack=new GenericStack<int>();
                    integerStack.Push(10);
                    integerStack.Push(20);
                    integerStack.Push(30);
                    Console.WriteLine("Peek value "+integerStack.Peek());
                    integerStack.Pop();
                    Console.WriteLine("Peek value " + integerStack.Peek());
                    //integerStack.Clear();
                    //Console.WriteLine("Peek value " + integerStack.Peek());                 
                    break;

                case 3:
                    GenericQueue<int> integerQueue = new GenericQueue<int>();
                    integerQueue.Enqueue(10);
                    integerQueue.Enqueue(20);
                    Console.WriteLine("Dequeue Element "+ integerQueue.Dequeue()); 
                    integerQueue.Enqueue(40);
                    Console.WriteLine("Peak Element is "+ integerQueue.Peek());
                    // integerQueue.Clear();
                    break;

                case 4:
                    BuiltInLinklist.LinkList();
                    break;

                case 5:
                    BuildInStack.BuildStack();
                    break;
                case 6:
                    BuildInQueue.BuildQueue();
                    break;

                default:
                    Console.WriteLine("Please Enter Valid Option");
                    break;
            }
        }
    }
}
