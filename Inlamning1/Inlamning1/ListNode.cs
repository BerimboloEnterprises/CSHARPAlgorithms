using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1
{

    //Code by Marcus Lindstedt

    /// <summary>
    /// The nodes in the lost and their pointers
    /// </summary>
    class ListNode
    {
        public object nodeContent {get; private set;}
        public ListNode next;
        
        /// <summary>
        /// dataValue represents the type of input allowed in a Node. In this case object means that we can take in anything. nextNode is a pointer to another node.
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="nextNode"></param>
        public ListNode(object dataValue, ListNode nextNode)
        {
            nodeContent = dataValue;
            next = nextNode;
        }
    }
}
