using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGit
{
    class DictionaryProcessor
    {
        private Dictionary<string, int> myDictionary;
        private int valueCounter;
        private System.Diagnostics.Stopwatch sw; 

        private DictionaryProcessor()
        {
            myDictionary = new Dictionary<string, int>();
            valueCounter = 1;
            sw = new System.Diagnostics.Stopwatch();
        }
        public void addOneItem(string newEntry)
        {
            myDictionary.Add(newEntry, valueCounter);
            valueCounter = valueCounter + 1;
        }

        public void addHugeList()
        {
            clear();
            for (int counter = 0; counter < 2000; counter++)
            {
                string valueToEnter = "New Entry " + valueCounter;
                myDictionary.Add(valueToEnter, valueCounter);
                valueCounter++;
            }
        }

        public void display()
        {
            if (myDictionary.Count == 0)
            {
                Console.WriteLine("Nothing is in the dictionary.");
            }
            else
            {
                foreach (KeyValuePair<string, int> pair in myDictionary)
                {
                    String key = pair.Key;
                    int value = pair.Value;
                    Console.WriteLine(key + " " + value);
                }
            }
        }

        public void delete(string item)
        {
            if(myDictionary.Count == 0)
            {
                Console.WriteLine("Nothing is in the dictionary.");
            }
            else if (myDictionary.ContainsKey(item))
            {
                myDictionary.Remove(item);
                valueCounter--;
            }
            else
            {
                Console.WriteLine("That element was not in the dictionary to begin with.");
            }
        }

        public void clear()
        {
            valueCounter = 1;
            myDictionary.Clear();
        }

        public void search(string item)
        {
            sw.Start();
            if (myDictionary.ContainsKey(item))
            {
                int foundValue = myDictionary[item];
                sw.Stop();
                Console.WriteLine("Found!!  " + "Time: " + sw.Elapsed);
            }   
        }
    }
}
