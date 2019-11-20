using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.ModelsLogic
{
    public class EventRepository : IEvent
    {
        private readonly EventContext context;

        public EventRepository(EventContext context)
        {
            this.context = context;
        }

        public Event Add(Event _event)
        {
            context.Events.Add(_event);
            context.SaveChanges();
            return _event;
        }

        public Event Update(Event eventChanges)
        {
            var _event = context.Events.Attach(eventChanges);
            _event.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return eventChanges;
        }

        public Event Delete(int Id)
        {
            Event _event = context.Events.Find(Id);
            if (_event != null)
            {
                context.Events.Remove(_event);
                context.SaveChanges();
            }
            return _event;
        }

        public Event GetEvent(int Id)
        {
            return context.Events.Find(Id);
        }

        public IEnumerable<Event> GetAllEvents()
        {
            var x = context.Events;
            return x;
        }
    }
}
