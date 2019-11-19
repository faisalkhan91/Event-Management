using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class Comment
    {
        int _commentId;
        string _content;
        DateTime _date;
        string _owner;

        [Key]
        public int CommentId { get => _commentId; set => _commentId = value; }
        public string Content { get => _content; set => _content = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Owner { get => _owner; set => _owner = value; }
    }
}
