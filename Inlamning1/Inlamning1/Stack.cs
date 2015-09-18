using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1
{

    //Code by Marcus Lindstedt
    class Stack<T>
    {
        private ListNode topNode = null;
        private int nElements;
        
        /// <summary>
        /// maxSize represents the maximum allowed size for the given stack
        /// </summary>
        /// <param name="maxSize"></param>
        public Stack()
        {
           
        }


        /// <summary>
        /// data represents the allowed input for the Stack. In this case we allow any type of object.
        /// </summary>
        /// <param name="data"></param>
       public void Push(T data)
        {         
                ListNode newNode = new ListNode(data, topNode);
                topNode = newNode;
                ++nElements;     
        } 
        /// <summary>
        /// Removes the top element in the stack. If there is no element it returns null.
        /// </summary>
        /// <returns></returns>
        public object Pop()
        {
            
            if(IsEmpty())
            {
                return null;
            }

            else
            {
                T data = (T)topNode.nodeContent;        //Saves the information in the top node into the data variable
                topNode = topNode.next;                 //Reassigns the second top node to be the top node. Garbage collector takes care of the old node
            
                --nElements;
                return data;
            }            
        }
        /// <summary>
        /// If the stack is empty returns null. If there is at least one element returns the information stored in the top node.
        /// </summary>
        /// <returns></returns>
        public object Peek()
        {
            if(!IsEmpty())
            {
                return topNode.nodeContent;
            }

            else
            {
                return null;
            }
        }
        /// <summary>
        /// Self explanatory. Returns the amount of elements in the stack
        /// </summary>
        /// <returns></returns>
        public int CountElements()
        {
            return nElements;
        }

        public bool IsEmpty()
        {
            return nElements == 0;
        }
    }
}

