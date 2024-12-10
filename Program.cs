using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_6_3
{
    internal class Program
    {
        // MSSA CCAD16 - 10DEC2024
        // CHRIS ALBRIGHT
        // ASSIGNMENT 6.3
        static void Main(string[] args)
        {
            // Assignment 6.3 ---------------------------------------------------------------------------------------------

            // You are developing a program to manage a call queue of customers using the Queue  in C#. The program creates
            // a queue of callers and demonstrates the functionality of enqueueing elements into the queue and iterating
            // over the elements and dequeuing.

            Console.WriteLine("Assignment 6.3 ---------------------------------------------------------------------");
            Console.WriteLine("CALL 'QUEUE'-ER:");
            char hold1 = 'y';
            do
            {
                Queue<Caller> callQueue = new Queue<Caller>();
                TimeSpan totalWaitingTime = TimeSpan.Zero;
                callQueue.Enqueue(new Caller("Anne", "111-11-1111", DateTime.Now));
                System.Threading.Thread.Sleep(1000);
                callQueue.Enqueue(new Caller("Brenden", "222-22-2222", DateTime.Now));
                System.Threading.Thread.Sleep(2000);
                callQueue.Enqueue(new Caller("Chris", "333-33-3333", DateTime.Now));

                Console.WriteLine("\nCurrent callers in the queue after formation: \n");
                foreach (Caller caller in callQueue)
                {
                    Console.WriteLine(caller.ToString());
                    Console.WriteLine();
                }
                Console.WriteLine("====================================================================================");
                Console.WriteLine("\nCall Center begins taking calls (with time delay between): \n");
                int minutes = 1;
                while (callQueue.Count>0)
                {
                    Console.WriteLine("Dequeing----------------------------------------------------------------------------");
                    //Simulate Deque Time
                    System.Threading.Thread.Sleep(1000);

                    Caller callerDeque = callQueue.Dequeue();
                    TimeSpan waitingTime = (DateTime.Now.AddMinutes(1+minutes) - callerDeque.CallTime );
                    
                    Console.WriteLine($"The following caller has been de-queued at {DateTime.Now.AddMinutes(1 + minutes)} -->: {callerDeque} --> Total wait time for caller was: {waitingTime} (HR:MIN:SEC)\n");
                    minutes++;
                }
                Console.WriteLine($"\nWant to run assignment 6.3 again? type y/n");
                hold1 = Console.ReadKey().KeyChar;
                hold1 = Char.ToLower(hold1);

            }
            while (hold1 == 'y');

            Console.WriteLine("\nGoodbye!");
        }
    }
}
