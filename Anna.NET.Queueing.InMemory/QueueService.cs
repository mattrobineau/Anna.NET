using Anna.NET.Core.Interfaces;
using Anna.NET.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Anna.NET.Queueing.InMemory
{
    public class QueueService : IQueueService
    {
        private ConcurrentQueue<Event> Queue;

        public async Task Add(Event ev)
        {
            lock(Queue)
            {
                if (Queue == null)
                {
                    Queue = new ConcurrentQueue<Event>();
                }

                Queue.Enqueue(ev);
            }

            return;
        }

        public async Task<IList<Event>> Take(int count)
        {
            var items = new List<Event>();
            lock(Queue)
            {
                if (Queue == null)
                {
                    return items;
                }

                for(var i = 0; i < count; i++)
                {
                    Queue.TryDequeue(out Event item);
                    items.Add(item);
                }
            }

            return items;
        }
    }
}
