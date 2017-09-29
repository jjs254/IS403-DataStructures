using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGit
{
    //Processes all operations related to a dictionary
    class DictionaryProcessor
    {
        private Dictionary<string, int> myDictionary;
        private int valueCounter;
        private System.Diagnostics.Stopwatch sw; 

        //Constructor
        private DictionaryProcessor()
        {
            myDictionary = new Dictionary<string, int>();
            valueCounter = 1;
            sw = new System.Diagnostics.Stopwatch();
        }

        //Adds one item to the dictionary
        public void addOneItem(string newEntry)
        {
            myDictionary.Add(newEntry, valueCounter);
            valueCounter = valueCounter + 1;
            Console.WriteLine("newEntry" + " was added to the dictionary");
        }

        //Adds 2000 items to the dictionary
        public void addHugeList()
        {
            clear();
            for (int counter = 0; counter < 2000; counter++)
            {
                string valueToEnter = "New Entry " + valueCounter;
                myDictionary.Add(valueToEnter, valueCounter);
                valueCounter++;
            }
            Console.WriteLine("2000 items added to the dictionary");
        }

        //Displays all items in the dictionary
        public void display()
        {
            if (myDictionary.Count == 0) //if nothing is in the dictionary
            {
                Console.WriteLine("There is nothing to display");
            }
            else //stuff is in the dictionary
            {
                foreach (KeyValuePair<string, int> pair in myDictionary)
                {
                    String key = pair.Key;
                    int value = pair.Value;
                    Console.WriteLine(key + " " + value);
                }
            }
        }

        //deletes a specified item from the dictionary
        public void delete(string item)
        {
            if(myDictionary.Count == 0) //if nothing is in the dictionary
            {
                Console.WriteLine("Nothing is in the dictionary.");
            }
            else if (myDictionary.ContainsKey(item)) //if the thing is in the dictionary
            {
                myDictionary.Remove(item);
                valueCounter--;
                Console.WriteLine("Deleted " + item);
            }
            else //the thing is not in the dictionary
            {
                Console.WriteLine("That element was not in the dictionary to begin with.");
            }
        }

        //clears the dictionary
        public void clear()
        {
            valueCounter = 1;
            myDictionary.Clear();
            Console.WriteLine("Dictionary cleared");
        }

        //searches the dictionary for a specified string; returns whether it was found and how long it took
        public void search(string item)
        {
            sw.Start();
            if (myDictionary.ContainsKey(item)) //item is in the dictionary
            {
                int foundValue = myDictionary[item];
                sw.Stop();
                Console.WriteLine("Found!!  " + "Time: " + sw.Elapsed);
            }
            else //item is not in the dictionary
            {
                sw.Stop();
                Console.WriteLine("Not found!!" + "Time: " + sw.Elapsed);
            }
        }
    }
}
