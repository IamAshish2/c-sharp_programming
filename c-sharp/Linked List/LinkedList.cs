using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Linked_List
{
    public class LinkedList
    {
        public  Node Head { get; set; } // head of the linked list 

        public void InsertFirst(int data)
        {
            //Create the node
            Node newNode = new Node();
            // Put the data in the node
            newNode.Data = data;
            // Put the old node in next
            newNode.Next = Head; // now this refrences the first element in the previous list

            // make the head the new node
            Head = newNode; // now the newly inserted element is the first element in the list
        }

        public Node DeleteFirst()
        {
            // Assign the temporary variable
            Node temp = Head;
            // Assign the next head
            Head = Head.Next;
            // return the temp variable i.e. the delted node
            return temp;
        }

        public void Iterate()
        {
            Console.WriteLine("Iterating through the list..");
            Node currentNode = Head; // assign the head/start of the list 
            while(currentNode != null) 
            {
                // display what's inside the node
                currentNode.DisplayNode();
                // move to the next node
                currentNode = currentNode.Next;
            }
        }


        public void InsertLast(int data)
        {
            // assign a current node
            Node currentNode = Head;
            // loop till we get to the last item i.e till the null is found
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            // initialize a new node
            Node newNode = new Node();
            // populate the new node with data
            newNode.Data = data;

            // insert a next refrence to the new node from the last node
            currentNode.Next = newNode;
        }

        public bool isEmpty()
        {
            return Head == null;
        }

    }
}
