using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGit
{
    public class QueueProcessor
    {
        
        private Queue<string> myQueue;
        private System.Diagnostics.Stopwatch sw;

        //Default Constructor
        public QueueProcessor()
        {
            myQueue = new Queue<string>();
            sw = new System.Diagnostics.Stopwatch();
        }

        //Add single item to queue
        public void addOneItem(string newEntry)
        {
            myQueue.Enqueue(newEntry);
            Console.WriteLine(newEntry + " was added to the queue");
        }

        //Clear queue and add 2000 items to queue
        public void addHugeList()
        {
            myQueue.Clear();
            for (int i = 0; i < 2000; i++)
            {
                myQueue.Enqueue("New Entry " + (i + 1));
            }
            Console.WriteLine("2000 items added to the queue");
        }

        //Display the contents of the queue
        public void display()
        {
            //Check for emmpty queue
            if (myQueue.Count == 0)
            {
                Console.WriteLine("There is nothing to display");
            }
            foreach (string entry in myQueue)
            {
                Console.WriteLine(entry);
            }
        }

        //Delete inputted item from queue
        public void delete(string item)
        {
            int counter = 0;
            string tempString;
            if(myQueue.Count() != 0)
            {
                //iterate through queue and enqueue all items except inputted item
                for (int i = 0; i < myQueue.Count(); i++)
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
                    //Output if item is deleted and how many times it appeared
                    Console.WriteLine("Deleted " + counter + " instance(s) of '" + item + "'");
                }
            }
            else
            {
                Console.WriteLine("There is nothing in the queue!");
            }
        }

        //Clear contents of queue
        public void clear()
        {
            myQueue.Clear();
            Console.WriteLine("Queue Cleared");
        }

        //Search through queue using stopwatch and output if item was found and time elapsed to search
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
