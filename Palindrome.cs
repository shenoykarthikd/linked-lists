using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Palindrome
    {
        //Check whether a string is a palindrome using linked lists.
        static void Main(string[] args)
        {
            LinkedListNode head = new LinkedListNode("r");
            head.Next = new LinkedListNode("e");
            head.Next.Next = new LinkedListNode("d");
            head.Next.Next.Next = new LinkedListNode("d");
            head.Next.Next.Next.Next = new LinkedListNode("p");
            head.Next.Next.Next.Next.Next = new LinkedListNode("r");

            Palindrome pal = new Palindrome();

            //Create a new linked list in the reverse order
            LinkedListNode reversed = pal.ReverseAndClone(head);

            //Check if the original linked list matches with the newly created reversed linked list
            Boolean isPalindrome = pal.IsEqual(head, reversed);
            
            //Print the linked list into a string
            String palindrome = pal.PrintString(head);

            //Write the output to the console.
            if(isPalindrome)
            {
                Console.WriteLine("The string {0} is a palindrome.", palindrome);
            }
            else
            {
                Console.WriteLine("The string {0} is NOT a palindrome.", palindrome);
            }
        }

        //Reversing the original linked list
        private LinkedListNode ReverseAndClone(LinkedListNode head)
        {
            LinkedListNode reversed = null;
            while (head != null)
            {
                LinkedListNode newNode = new LinkedListNode(head.Data);
                newNode.Next = reversed;
                reversed = newNode;
                head = head.Next;
            }
            return reversed;
        }

        //Comparing the original linked list with the reversed linked list
        private bool IsEqual(LinkedListNode head, LinkedListNode reversed)
        {
            while(head.Next != null && reversed.Next != null)
            {
                if(head.Data != reversed.Data)
                {
                    Console.WriteLine("Unmatched Data: Head - {0}; Reversed - {1}", head.Data, reversed.Data);
                    return false;
                }
                head = head.Next;
                reversed = reversed.Next;
            }
            return true;
        }
        
        //Print the linked list
        private string PrintString(LinkedListNode head)
        {
            string str = "";
            while (head != null)
            {
                str += head.Data;
                head = head.Next;
            }
            return str;
        }
    }

    class LinkedListNode
    {
        public LinkedListNode Next;
        public string Data;

        public LinkedListNode(string data)
        {
            Data = data;
        }
    }
}
