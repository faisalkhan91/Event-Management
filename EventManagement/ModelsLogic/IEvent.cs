using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.ModelsLogic
{
    public interface IEvent
    {
        Event Add(Event _event);
        Event Update(Event eventChanges);
        Event Delete(int Id);
        Event GetEvent(int Id);
        IEnumerable<Event> GetAllEvents();
    }
}
