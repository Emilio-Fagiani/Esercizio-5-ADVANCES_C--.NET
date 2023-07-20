using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5_ADVANCES_C__.NET
{
    public class MyQueue<T>
    {
        private Queue<T> queue;

        public MyQueue()
        {
            queue = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("La coda è vuota.");
            }

            return queue.Dequeue();
        }

        public T Peek()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("La coda è vuota.");
            }

            return queue.Peek();
        }

    }
}
