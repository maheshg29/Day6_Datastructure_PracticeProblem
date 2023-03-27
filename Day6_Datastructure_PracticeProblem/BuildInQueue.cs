using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Datastructure_PracticeProblem
{
    public class BuildInQueue
    {
        public static void BuildQueue()
        {
            Queue<int> intQueue = new Queue<int>();
            // Create Operation
            intQueue.Enqueue(10);
            intQueue.Enqueue(20);
            intQueue.Enqueue(30);

            // Read Operation
            Console.WriteLine("Data in Queue is ");
            foreach (var data in intQueue)
            {
                Console.WriteLine(data);
            }

            //Delete operation

            Console.WriteLine("after Dequeue operation " + intQueue.Dequeue());
            //intQueue.Clear();

            Console.WriteLine("Peak Element is "+ intQueue.Peek()); //Peak operation

            Console.WriteLine("Data in Queue after Dequeue is ");
            foreach (var data in intQueue) // print data in queue after all operation
            {
                Console.WriteLine(data);
            }
           

        }
    }
}
