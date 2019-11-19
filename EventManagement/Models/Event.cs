using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class Event 
    {
        int _eventId;
        string _title;
        DateTime _startDate;
        DateTime _endDate;
        int _duration;
        string _description;
        string _location;
        EventType _event; // Can also use Boolean
        string _author;
        
        [Key]
        public int EventId { get => _eventId; set => _eventId = value; }
        [Required]
        public string Title { get => _title; set => _title = value; }
        [Required]
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public string Description { get => _description; set => _description = value; }
        public string Location { get => _location; set => _location = value; }
        public EventType EventType { get => _event; set => _event = value; }
        public string Author { get => _author; set => _author = value; }
        public List<Comment> CommentList { get; set; }
    }
}
