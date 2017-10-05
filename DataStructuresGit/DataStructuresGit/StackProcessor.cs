using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGit
{
    public class StackProcessor
    {
        private Stack<string> myStack; //create stack

        private System.Diagnostics.Stopwatch sw; //create stopwatch

        public StackProcessor()//constructor
        {
            myStack = new Stack<string>();
            sw = new System.Diagnostics.Stopwatch();
        }

        public void addOneItem(string newEntry)
        {
            myStack.Push(newEntry); //add item newEntry to Stack

            Console.WriteLine(newEntry + " was added to the Stack");
        }

        //first clears the data structure and then generate 2,000 items in the data structure with the 
        //value of “New Entry” concatenated with the number. For example, New Entry 1, New Entry 2, New Entry 3.         
        public void addHugeList() 
        {
            clear(); //clear stack

            for (int iCount = 0; iCount < 2000; iCount++)
            {
                string newEntry = "New Entry " + (iCount + 1);
                myStack.Push(newEntry);
            }

            Console.WriteLine("2000 items added to the Stack");
        }

        //display the contents of the data structure. You must use the foreach loop when displaying the data.
        //Handle any errors and inform the user.
        public void display()
        {
            if (myStack.Count == 0)//make sure they have added item into the stack
            {
                Console.WriteLine("Nothing is in the Stack.");
            }
            else
            {
                foreach (string item in myStack)//iterate the Stack
                {
                    Console.WriteLine(item);
                }
            }
            
        }

        public void delete(string item)
        {           
            if (myStack.Count == 0) //handler to see if there is any items in the Stack
            {
                Console.WriteLine("Nothing is in the Stack.");
            }
            else if(myStack.Contains(item))//checks to see if the item entered is in the Stack
            {
                Stack<string> myOtherStack = new Stack<string>();//make other stack
                int iCounter = 0;
                int counter = myStack.Count();
                for (int i = 0; i < counter; i++)
                {

                    if (myStack.Peek().Equals(item))
                    {
                        myStack.Pop();
                        iCounter++;
                    }
                    else
                    {
                        myOtherStack.Push(myStack.Pop());
                    }
                }
                counter = myOtherStack.Count();
                for (int n = 0; n < counter; n++)//put back on myStack
                {
                    myStack.Push(myOtherStack.Pop());
                }

                Console.WriteLine("Deleted " + iCounter + " instance(s) of '"+ item + "'");
                
                /*
                //put items on different stack until you find the item user wants to delete
                while (myStack.Peek() != item)
                {
                    myOtherStack.Push(myStack.Pop());
                }

                myStack.Pop();// delete the item

                //put items back on myStack
                while(myOtherStack.Count != 0)
                {
                    myStack.Push(myOtherStack.Pop());
                } 
                */
            }
            else
            {
                Console.WriteLine("That item is not in the Stack!");
            }
        }

        //clear the stack
        public void clear()
        {
            myStack.Clear();
            Console.WriteLine("Stack cleared.");
        }

        //search for item and return if it was found and the time elapsed
        public void search(string item)
        {
            sw.Start(); //start stopwatch
            if (myStack.Contains(item))
            {
                sw.Stop();
                Console.WriteLine("Found '" + item + "'!!  Time elapsed: " + sw.Elapsed);
            }
            else
            {
                sw.Stop();
                Console.WriteLine("'" + item + "' not found!  Time elapsed: " + sw.Elapsed);
            }
            sw.Reset();//reset stopwatch
        }

    }
}
