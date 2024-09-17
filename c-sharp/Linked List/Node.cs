using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Linked_List
{
    public class Node
    {
        public int Data {  get; set; }
        public Node Next { get; set; } // self refrence to the node
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
        ////// creating a new node 
        ////Node nodeA = new Node();
        ////nodeA.Data = 1; // inserting data into the node

        ////Node nodeB = new Node();
        ////nodeB.Data = 209;

        ////Node nodeC = new Node();
        ////nodeC.Data = 325;

        ////Node nodeD = new Node();
        ////nodeD.Data = 456;

        ////// Pointer to the next Node
        ////nodeA.Next = nodeB; // Pointer that points to the next node
        ////nodeB.Next = nodeC;
        ////nodeC.Next = nodeD;
        ////nodeD.Next = null;
    }
}
