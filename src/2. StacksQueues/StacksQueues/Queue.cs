using System;

namespace StacksQueues
{
    public class Queue<T>
    {
        private QueueNode<T> first;
        private QueueNode<T> last;

        public void Add(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);
            if (last != null)
            {
                last.next = t;
            }
            last = t;
            if (first == null)
            {
                first = last;
            }
        }

        public T Remove()
        {
            if (first == null) throw new NullReferenceException();
            T data = first.data;
            first = first.next;
            if (first == null)
            {
                last = null;
            }
            return data;
        }

        public T Peek()
        {
            if (first == null) throw new NullReferenceException();
            return first.data;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }

    public class QueueNode<T>
    {
        public T data;
        public QueueNode<T> next;

        public QueueNode(T data)
        {
            this.data = data;
        }
    }
}
