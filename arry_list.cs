//1. Write a  c# program to create and display a Singly Linked List.
using System;
using arry_list;

namespace arry_list
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    //create Singly Linked List
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;

        }
        public void Add(int data)
        {
            Node new_node = new Node(data);

            if (head == null)
            {
                head = new_node;
            }


            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new_node;
            }
        }
    }
}

//display a Singly Linked List.

//public void display_list()
//{
//    if (head == null)
//    {
//        Console.WriteLine("this list is dmpty");
//    }
//    Node current = head;
//    while (current != null)
//    {
//        Console.Write(current.Data + "->");
//        current = current.Next;
//    }
//    Console.WriteLine("null");
//}

 // 2- Display Linked list in reverse
   //public void Reverse(Node node) {
      //if (node == null) {
       // return;
      //}
      //DipslayReverse(node.next);
      //Console.Write(node.data + " -> ");
    //}

























// 2. Write a  c# program to create a singly linked list of n nodes and display it in reverse order.
// 3. Write a  c# program to create a singly linked list of n nodes and count the number of nodes.
// 4. Write a  c# program to insert a node at any position in a Singly Linked List.
// 5. Write a  c# program to insert a node at the beginning of a Singly Linked List.
// 6. Write a  c# program to insert a node at the end of a Singly Linked List.
// 7. Write a  c# program to get a node in an existing singly linked list.
// 8. Write a  c# program to find the first index that matches a given element. Return -1 for no matching.
// 
//9. Write a  c# program to check whether a single linked list is empty or not. Return true otherwise false.
// 10. Write a  c# program to empty a singly linked list by pointing the head towards null.
// 11. Write a  c# program that removes the node from the singly linked list at the specified index.
// 12. Write a  c# program that calculates the size of a Singly Linked list.
// 13. Write a  c# program that removes the first element from a Singly Linked list.
// 14. Write a  c# program that removes the tail element from a Singly Linked list.
// 15. Write a  c# program to convert a Singly Linked list into an array.
// 16. Write a  c# program to convert a Singly Linked list into a string.
// 17. Write a  c# program to get the index of an element in a Singly Linked list
//18. Write a  c# program to check if an element is present in the Singly Linked list.
