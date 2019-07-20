using System;

namespace StacksQueues
{
    /// <summary>
    /// pop(): Remove the top item from the stack. 
    /// push(i tern): Add an item to the top of the stack.
    /// peek(): Return the top of the stack. 
    /// isEmpty(): Return true if and only if the stack is empty.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        private StackNode<T> top;

        public T Pop()
        {
            if (top == null) throw new StackOverflowException();
            T item = top.data;
            top = top.next;
            return item;
        }

        public void Push(T item)
        {
            StackNode<T> t = new StackNode<T>(item);
            t.next = top;
            top = t;
        }

        public T Peek()
        {
            if (top == null) throw new StackOverflowException();
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class StackNode<T>
    {
        public T data;
        public StackNode<T> next;

        public StackNode(T data)
        {
            this.data = data;
        }
    }
}
