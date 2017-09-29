using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGit
{
    class QueueProcessor
    {
        
        private Queue<string> myQueue;
        private System.Diagnostics.Stopwatch sw;

        private QueueProcessor()
        {
            myQueue = new Queue<string>();
            sw = new System.Diagnostics.Stopwatch();
        }

        public void addOneItem(string newEntry)
        {
            myQueue.Enqueue(newEntry);
            Console.WriteLine(newEntry + " was added to the queue");
        }

        public void addHugeList()
        {
            myQueue.Clear();
            for (int i = 0; i < 2000; i++)
            {
                myQueue.Enqueue("New Entry " + (i + 1));
            }
            Console.WriteLine("2000 items added to the queue");
        }

        public void display()
        {
            if (myQueue.Count == 0)
            {
                Console.WriteLine("There is nothing to display");
            }
            foreach (string entry in myQueue)
            {
                Console.WriteLine(entry);
            }
        }

        public void delete(string item)
        {
            int counter = 0;
            string tempString;
            if(myQueue.Count() != 0)
            {
                foreach (string entry in myQueue)
                {
                    tempString = myQueue.Dequeue();
                    if (tempString != item)
                    {
                        myQueue.Enqueue(tempString);
                    }
                    else
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine("That item is not in the queue!");
                }
                else
                {
                    string outputLine = "Deleted " + counter + " instance(s) of '" + item + "'";
                }
            }
            else
            {
                Console.WriteLine("There is nothing in the queue!");
            }
        }

        public void clear()
        {
            myQueue.Clear();
            Console.WriteLine("Queue Cleared");
        }

        public void search(string item)
        {
            sw.Start();
            if (myQueue.Contains(item))
            {
                sw.Stop();
                Console.WriteLine("Found!!  Time Elapsed: " + sw.Elapsed);
            }
            else
            {
                sw.Stop();
                Console.WriteLine("'" + item + "' not found in the queue!  Time elapsed: " + sw.Elapsed);
            }
            sw.Reset();
        }
    }
}
