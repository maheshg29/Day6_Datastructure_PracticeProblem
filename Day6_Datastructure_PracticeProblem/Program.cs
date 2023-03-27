using System;
using System.Collections.Generic;
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
            Console.WriteLine("Select any one option for \n 1. Generic Custom Linklist");
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
                default:
                    Console.WriteLine("Please Enter Valid Option");
                    break;
            }
        }
    }
}
