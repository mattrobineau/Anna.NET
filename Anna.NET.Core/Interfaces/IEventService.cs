using Anna.NET.Core.Models;
using System.Threading.Tasks;

namespace Anna.NET.Core.Interfaces
{
    public interface IEventService
    {
        Task Add(Event e);
    }
}
