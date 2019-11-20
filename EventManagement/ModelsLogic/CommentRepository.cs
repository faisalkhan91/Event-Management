using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.ModelsLogic
{
    public class CommentRepository : IComment
    {
        private readonly EventContext context;

        public CommentRepository(EventContext context)
        {
            this.context = context;
        }

        public Comment Add(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment;
        }

        public Comment Update(Comment commentChanges)
        {
            var comment = context.Comments.Attach(commentChanges);
            comment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return commentChanges;
        }

        public Comment Delete(int Id)
        {
            Comment comment = context.Comments.Find(Id);
            if (comment != null)
            {
                context.Comments.Remove(comment);
                context.SaveChanges();
            }
            return comment;
        }

        public Comment GetComment(int Id)
        {
            return context.Comments.Find(Id);
        }

        public IEnumerable<Comment> GetAllComments()
        {
            var x = context.Comments;
            return x;
        }
    }
}
