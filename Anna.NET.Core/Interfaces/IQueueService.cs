using Anna.NET.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Anna.NET.Core.Interfaces
{
    public interface IQueueService
    {
        Task Add(Event ev);
        Task<IList<Event>> Take(int count);
    }
}
