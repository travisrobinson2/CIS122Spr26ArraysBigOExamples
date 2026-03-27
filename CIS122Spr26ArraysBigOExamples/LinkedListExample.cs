using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{

    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node (int data)
        {
            Data = data;
        }
    }

    public class LinkedListExample
    {
        public Node Head { get; set; }
        public int Count { get; private set; } = 0;

        public void Traverse()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                currentNode = currentNode.Next;
            }
        }

        public int FindFirst(int targetValue)
        {
            Node currentNode = Head;
            int idx = 0;

            if(currentNode == null)
            { 
                return -1;
            }

            while(currentNode != null)
            {
                if(currentNode.Data == targetValue)
                {
                    return idx;
                }
                currentNode = currentNode.Next;
                idx++;
            }
            return -1;
        }

        public bool RemoveFirst(int targetValue)
        {
            Node currentNode = Head;
            if(currentNode != null)
            {
                return false;
            }


            if(currentNode.Data == targetValue)
            {
                Head = currentNode.Next;
                Count--;
                return true;
            }

            while (currentNode.Next.Data != null)
            {
                if(currentNode.Next.Data == targetValue)
                {

                    currentNode.Next = currentNode.Next.Next;
                    Count--;
                    return true;
                }
            }
        }





        public void RemoveVeryFirst()
        {

            if (Head == null)
            {
                return;
            }
            else
            {
                Head = Head.Next;
            }
        }


        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        //public int FindFirst(int targetValue)
        //{
        //    int idx = 0;

        //    Node current = Head;
        //    while (current != null)
        //    {
        //        if(current.Data == targetValue)
        //        {
        //            return idx;
        //        }
        //        current = current.Next;
        //        idx++;
        //    }
        //    return -1;
        //}

        public bool Remove(int targetValue)
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                if(Head.Data == targetValue)
                {
                    Head = Head.Next;
                    return true;
                }

                Node current = Head.Next;
                while (current != null)
                {
                    if(current.Data == targetValue)
                    {
                        current.Next = current.Next.Next;
                        return true;
                    }
                    current = current.Next;
                }
            }
            return false;
        }

    }
}
