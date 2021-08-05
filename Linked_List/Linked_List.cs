using System;
namespace Linked_List
{
    /**
     * This is a singly linked list that can only point at the next node.
     */
    public class Linked_List<T> : Linked_ListBase
    {
        public Node<T> head;
        public Node<T> tail;

        // method for inserting additional nodes to the list.
        public void AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if(head == null) // if head is empty
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        // counts the total amount of nodes inside the list.
        public void Count()
        {
            var current = head;
            var count = 0;
            while(current!=null)
            {
                current = current.next;
                count++;
            }
            Console.WriteLine($"There are currently {count} nodes in this list.");
        }

        // displays all the nodes that are currently present in this list.
        public void Display()
        {
            Node<T> current = head;

            if (head == null)
            {
                Console.WriteLine("List is empty!");
            }
            Console.WriteLine("These nodes are currently present in this list:");
            while (current != null)
            {
                Console.WriteLine(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
