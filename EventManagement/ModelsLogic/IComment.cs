using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.ModelsLogic
{
    public interface IComment
    {
        Comment Add(Comment _event);
        Comment Update(Comment eventChanges);
        Comment Delete(int Id);
        Comment GetComment(int Id);
        IEnumerable<Comment> GetAllComments();
    }
}
