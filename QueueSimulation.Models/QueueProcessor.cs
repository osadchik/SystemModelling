using System.Collections.Generic;

namespace QueueSimulation.Models
{
    internal class QueueProcessor
    {
        public int Count 
        {
            get
            {
                return queue.Count;
            } 
        }

        private Queue<Element> queue;
        private int maxQueue;

        public QueueProcessor(int maxQueue)
        {
            this.maxQueue = maxQueue;
            queue = new Queue<Element>(maxQueue);
        }

        public bool AddElement(Element newElement)
        {
            if (queue.Count < maxQueue)
            {
                queue.Enqueue(newElement);
                return true;
            }

            return false;
        }

        public Element ProcessItem()
        {
            return queue.Dequeue();
        }
    }
}
