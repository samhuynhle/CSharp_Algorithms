using System;

public class LinkedListIS
{
    public node head;
    public node sorted;
    public class node
    {
        public int val;
        public node next;
        public node(int val)
        {
            this.val = val;
        }
    }
    // Push node into the front of the linked list
    void push(int val)
    {
        node newnode = new node(val);
        newnode.next = head;
        head = newnode;
    }
    // method to sort current linked list
    void insertionSort(node headref)
    {
        // initialize another list to sort given list
        sorted = null;
        node current = headref;
        // traverse through the given linked list
        while(current != node)
        {
            // store so we can increment through the given linked list
            node next = current.next;
            sortedInsert(current);
            current = next;
        }
        head = sorted;
    }

    // method to insert the nodes from the given linked list into the sorted linked list
    void sortedInsert(node newnode)
    {
        if(sorted == null || sorted.val >= newnode.val)
        {
            newnode.next = sorted;
            sorted = newnode;
        }
        else
        {
            node current = sorted;
            while(current.next != null && current.next.val < newnode.val)
            {
                current = current.next;
            }
            newnode.next = current.next;
            current.next = newnode;
        }
    }

    void printlist(node head)
    {
        while(head != null)
        {
            while(head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
    }
}