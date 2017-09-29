using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool term = false; // loop termination variable
            StackProcessor sp = new StackProcessor();
            QueueProcessor qp = new QueueProcessor();
            DictionaryProcessor dp = new DictionaryProcessor();
            while (term == false)
            {
                string selection = "";
                string subSelect = "";
                bool subTerm = false;  //subloop termination variable
                //menu
                Console.Write("1. Stack\n2. Queue\n3. Dictionary\n4. Exit\n\n");
                selection = Console.ReadLine();
                if (selection == "Exit" | selection == "4")
                {
                    term = true; //boolean that exits the program when true
                }
                else if (selection == "Stack" | selection == "1")
                {
                    while (subTerm == false)
                    {
                        //subMenu
                        Console.Write("\n1. Add one time to Stack\n2. Add Huge List of Items to Stack\n3. Display Stack\n4. Delete from Stack\n5. Clear Stack\n6. Search Stack\n7. Return to Main Menu\n\n");
                        subSelect = Console.ReadLine();
                        if (subSelect == "Add one time to Stack" | subSelect == "1")
                        {
                            Console.WriteLine("\nPlease enter one item to add\n");
                            sp.addOneItem(Console.ReadLine());
                        }
                        else if (subSelect == "Add Huge List of Items to Stack" | subSelect == "2")
                        {
                            sp.addHugeList();
                        }
                        else if (subSelect == "Display Stack" | subSelect == "3")
                        {
                            sp.display();
                        }
                        else if (subSelect == "Delete from Stack" | subSelect == "4")
                        {
                            Console.WriteLine("\nPlease enter one item to delete\n");
                            sp.delete(Console.ReadLine());
                        }
                        else if (subSelect == "Clear Stack" | subSelect == "5")
                        {
                            sp.clear();
                        }
                        else if (subSelect == "Search Stack" | subSelect == "6")
                        {
                            Console.WriteLine("\nPlease enter one item to search\n");
                            sp.search(Console.ReadLine());
                        }
                        else if (subSelect == "Return to Main Menu" | subSelect == "7")
                        {
                            subTerm = true;
                        }
                    }//end of sub while loop
                }//end of Stack else statement
                else if (selection == "Queue" | selection == "2")
                {
                    while (subTerm == false)
                    {
                        //subMenu
                        Console.Write("\n1. Add one time to Queue\n2. Add Huge List of Items to Queue\n3. Display Queue\n4. Delete from Queue\n5. Clear Queue\n6. Search Queue\n7. Return to Main Menu\n\n");
                        subSelect = Console.ReadLine();
                        if (subSelect == "Add one time to Queue" | subSelect == "1")
                        {
                            Console.WriteLine("\nPlease enter one item to add\n");
                            qp.addOneItem(Console.ReadLine());
                        }
                        else if (subSelect == "Add Huge List of Items to Queue" | subSelect == "2")
                        {
                            qp.addHugeList();
                        }
                        else if (subSelect == "Display Queue" | subSelect == "3")
                        {
                            qp.display();
                        }
                        else if (subSelect == "Delete from Queue" | subSelect == "4")
                        {
                            Console.WriteLine("\nPlease enter one item to delete\n");
                            qp.delete(Console.ReadLine());
                        }
                        else if (subSelect == "Clear Queue" | subSelect == "5")
                        {
                            qp.clear();
                        }
                        else if (subSelect == "Search Queue" | subSelect == "6")
                        {
                            Console.WriteLine("\nPlease enter one item to search\n");
                            qp.search(Console.ReadLine());
                        }
                        else if (subSelect == "Return to Main Menu" | subSelect == "7")
                        {
                            subTerm = true;
                        }
                    }//end of sub while loop
                }//end of Queue else statement
                else if (selection == "Dictionary" | selection == "3")
                {
                    while (subTerm == false)
                    {
                        //subMenu
                        Console.Write("\n1. Add one time to Dictionary\n2. Add Huge List of Items to Dictionary\n3. Display Dictionary\n4. Delete from Dictionary\n5. Clear Dictionary\n6. Search Dictionary\n7. Return to Main Menu\n\n");
                        subSelect = Console.ReadLine();
                        if (subSelect == "Add one item to Dictionary" | subSelect == "1")
                        {
                            Console.WriteLine("\nPlease enter one item to add\n");
                            dp.addOneItem(Console.ReadLine());
                        }
                        else if (subSelect == "Add Huge List of Items to Dictionary" | subSelect == "2")
                        {
                            dp.addHugeList();
                        }
                        else if (subSelect == "Display Dictionary" | subSelect == "3")
                        {
                            dp.display();
                        }
                        else if (subSelect == "Delete from Dictionary" | subSelect == "4")
                        {
                            Console.WriteLine("\nPlease enter one item to delete\n");
                            dp.delete(Console.ReadLine());
                        }
                        else if (subSelect == "Clear Dictionary" | subSelect == "5")
                        {
                            dp.clear();
                        }
                        else if (subSelect == "Search Dictionary" | subSelect == "6")
                        {
                            Console.WriteLine("\nPlease enter one item to search\n");
                            dp.search(Console.ReadLine());
                        }
                        else if (subSelect == "Return to Main Menu" | subSelect == "7")
                        {
                            subTerm = true;
                        }
                    }//end of sub while loop
                }//end of Dictionary else statement
                Console.Write("\n");
            }//end of menu while loop bracket
            
        }
    }
}
