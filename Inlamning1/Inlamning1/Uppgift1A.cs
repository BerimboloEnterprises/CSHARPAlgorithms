using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1
{
    //Code by Marcus Lindstedt


    /// <summary>
    /// This program creates a stack, pushes, peeks, pops and counts the elements on the stack.
    /// </summary>
    class Uppgift1A
    {
     
        public Uppgift1A()
        {
            Stack<string> stack = new Stack<string>();          //Creates the stack with 10 000 slots
            Console.WriteLine(stack.CountElements());           //Counts the elements on the stack (in this case none)
            stack.Push("This stack is popping");                //Push 1 element with the assigned string onto the stack
            Console.WriteLine(stack.CountElements());           //1 element is now on the stack
            Console.Write(stack.Peek());                        //Checks the top element of the stack to find its data
            stack.Push("hej");                                  //Push 1 element containing string with "hej"
            Console.WriteLine(stack.CountElements());           //Counts elements on the stack (2 in this case)
            Console.WriteLine(stack.Pop() + "," + stack.Pop()); //Pops 2 elements from the stack and writes out what they were
            Console.WriteLine(stack.CountElements());           //Counts elements on the stack (none)
        }
    }
}
