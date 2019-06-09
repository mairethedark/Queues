using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue myQ = new Queue();

            myQ.Enqueue("1");
            myQ.Enqueue("2");
            myQ.Enqueue("3");
            myQ.Enqueue("4");
            myQ.Enqueue("5");

            Console.WriteLine("There are {0} items in the Queue", myQ.Count);

            while (myQ.Count > 0)
            {
                string str = (string)myQ.Dequeue();
                Console.WriteLine("Dequeueing Object {0}", str); 
            }
            
            Console.ReadLine();
        }
    }
}
