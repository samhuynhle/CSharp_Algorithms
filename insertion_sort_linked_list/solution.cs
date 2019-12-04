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
    void push(int val)
    {
        node newnode = new node(val);
        newnode.next = head;
        head = newnode;
    }
    void insertionSort(node headref)
    {
        sorted = null;
        node current = headref;
        while(current != node)
        {
            node next = current.next;
            sortedInsert(current);
            current = next;
        }
        head = sorted;
    }

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