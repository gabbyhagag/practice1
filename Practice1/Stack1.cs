using System;
using System.Collections.Generic;

namespace Practice1
{
    public class Stack1
    {
        Node anchor;
        Stack<int> maxUp;
        Stack<int> maxDown;

        public Stack1()
        {
            anchor = new Node(123);
            maxUp = new Stack<int>();
            maxDown = new Stack<int>();
        }

        public void Push(int item)
        {
            Node n = new Node(item);
            if (maxUp.Count == 0 || item >= maxUp.Peek())
                maxUp.Push(item);
            else maxDown.Push(item);
            n.Next = anchor.Next;
            anchor.Next = n;
        }

        public int Pop()
        {
            Node n = anchor.Next;
            if (n == null)
                throw new Exception("stack was empty");
            if (anchor.Next.Value == maxUp.Peek())
                maxUp.Pop();
            else maxDown.Pop();
            anchor.Next = anchor.Next.Next;

            return n.Value;
        }

        public int Max ()
        {
            if (maxDown.Count == 0 || maxUp.Peek() >= maxDown.Peek())
                return maxUp.Peek();
            return maxDown.Peek();
        }

        class Node
        {
            public Node(int v)
            {
                this.Value = v;
            }
            public int Value { get; set; }
            public Node Next { get; set; }
        }
    }
}
