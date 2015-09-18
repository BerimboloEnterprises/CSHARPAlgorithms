using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1
{
    //Code by Marcus Lindstedt


    /// <summary>
    /// This program checks input text for syntax errors
    /// </summary>
    class Uppgift1B
    {
        /// <summary>
        /// Defines "openers" and "closers" for qualification
        /// </summary>
        private char[] openChar = { '{', '(', '[' };
        private char[] closeChar = { '}', ')', ']' };

        public Uppgift1B()
        { 

            Console.WriteLine("Enter text to qualify! If you write exit the application will terminate");

            
            while(true)
            {
                String input = Console.ReadLine();

                if(input.ToLower() == "exit")                           //Parses the input text to lowercase and if exit is entered closes the application
                {
                    break;
                }
                
                Stack<char> stack = new Stack<char>();                  //Creates the stack and assigns the type char

                StringBuilder errorHandling = new StringBuilder();      //Creates an errorhandler that will display the problems

                foreach(char c in input)
                {
                    if(openChar.Contains(c))                            //Goes through the String and then pushes "openers" onto the stack
                    {
                        stack.Push(c);
                    }

                    else if(closeChar.Contains(c))
                    {
                        if(stack.IsEmpty())
                        {
                            errorHandling.AppendLine("\n" + c + " does not have it's corresponding opener!");
                            continue;
                        }

                        char previousElement = (char)stack.Pop();

                        if(!Qualify(previousElement,c))
                        {
                            errorHandling.AppendLine("\n" + previousElement + "and " + c + " does not match!");
                        }
                    }
                }

                if(!stack.IsEmpty())                                    //If there are any elements on the stack one or more tags are faulty
                {
                    errorHandling.AppendLine(" \n You messed up");
                }
                
                if(errorHandling.Length != 0)                           //Prints out any errors that occurred during runtime
                {
                    Console.WriteLine("The following errors occured: \n" + errorHandling);
                }
            }
        }
        
        /// <summary>
        /// Checks if the input is a matching pair
        /// </summary>
        /// <param name="x">The first parameter(in this case char)</param>
        /// <param name="y">The second parameter(in this case char)</param>
        /// <returns></returns>
        public bool Qualify(char x, char y)
        {
            if ((x == '(' && y == ')') || (y == '(' && x == ')'))
            {
                return true;
            }

            if ((x == '[' && y == ']') || (y == '[' && x == ']'))
            {
                return true;
            }

            if (x == '{' && y == '}' || (y == '{' && x == '}'))
            {
                return true;
            }

            return false;
        }
    }
}
