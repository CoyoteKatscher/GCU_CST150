// Brian Potter
// CST-150
// 04/10/2022
// Initial code is written verbatim from "CST-150-RS-Activity10Code.docx"
// The only code that is of my own work are the corrections I made in the following methods:
// containsElement and union.
// All other code belongs to the author of the activity guide. Original code that was corrected has been commented out.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set returnValue = new Set();
            //make some sets
            Set A = new Set();
            Set B = new Set();

            // put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            // display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            // debug breakpoint #2 - determine why this call produces a logic error
            /* When A.union(B) is called in this line of code, the output is just repeating
             * the values in "Set B". 
             */
            /* debug breakpoint #3 - While debugging logic in breakpoint #2 it was observed that the values of Set A were being changed.
             * re-wrote the union method so the initial values in Set A and Set B were not changed and the valid union Set was returned
             * for the WriteLine call
             */

            Console.WriteLine("A union B: " + A.union(B));
            
            // display original sets (should be unchanged)            
            Console.WriteLine("After union operation");
            
            /* continuing breakpoint #2 debugging -
             * when the next line is called, "Set A" displays the correct Set union value
             */
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }

    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        
        public bool addElement(int val)
        //public void addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }            
        }

        private bool containsElement(int val)
        {
            // debug breakpoint #1 - Determine why loop not successfully incrementing i
            /* Determined loop is prematuerely exiting due to "else return false" statement
             * since the loop is retuning a value the method code terminates and loop therefore
             * terminates
             */
            for(int i = 0;i < elements.Count;i++)
            {
                if (val == elements[i])
                    return true;
                /* this else breaks the loop due to it returning a value
                else
                    return false;
                */
            }
            return false;
            

        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        // Breakpoint 2: While stepping through debug and watching values I noticed that rhs are the values of "Set B" and do not
        // change. The value of "this" was correctly creating the union value. Change the return to this and the proper value
        // is showing.
        // Breakpoint 3: While observing the behavor during debug of Breakpoint 2 it was noticed the value of "Set A" is being
        // changed to the union value. Decided to re-write the union method.
        
        public Set union(Set B)
        {
            // Variable to hold the value of the union set.
            Set unionValue = new Set();

            // Loop 1: Due to how elements are added to the set, Set A will not have any duplicate values. Initializing the unionValue variable
            // with the values from Set A.
            for (int i = 0; i < this.elements.Count; i++)
            {
                unionValue.addElement(this.elements[i]);
            }

            // Loop 2: With unionValue initialized with contents of Set A, now need to compare the values in Set B to determine if it
            // qualifies to be added to the union set. If the value of Set B at index i is unique it is added to the unionValue set.
            for (int i = 0; i < B.elements.Count; i++)
            {
                unionValue.addElement(B.elements[i]);
            }
            // Once both sets have been evaluated, return the unionValue. This will NOT change the initial values in Set A and Set B
            return unionValue;
        }

        /*
        public Set union(Set rhs)        
        {
            for (int i = 0;i < rhs.elements.Count;i++)
            {
                this.addElement(rhs.elements[i]);                
            }
            //return rhs;         
            return this;
        }*/
    }
}