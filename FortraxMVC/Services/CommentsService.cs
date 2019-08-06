using FortraxMVC.Data;
using FortraxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services
{
    public class CommentsService
    {
        public ApplicationDbContext db { get; }
        public CommentsService(ApplicationDbContext db)
        {
            this.db = db;
        }


        public Comment CreateComment(string userId, string productId, string content, double review)
        {
            Comment comment = new Comment
            {
                AuthorId = userId,
                ProductId = productId,
                PostedOn = DateTime.UtcNow,
                Review = review,
                Text = content
            };

            db.Comments.Add(comment);

            db.SaveChanges();


            return comment;

        }

        public void DeleteComment(string id)
        {
           var  commentToRemove =  this.db.Comments.Find(id);

            if (commentToRemove == null)
            {
                throw new NullReferenceException("Comment does not exist");
            }

            this.db.Comments.Remove(commentToRemove);
            this.db.SaveChanges();
        }

        public void EditComment(string id, string content, double review)
        {
            var comment = this.db.Comments.Find(id);
            if (comment == null)
            {
                throw new NullReferenceException("No such comment exists!");
            }


            this.db.Comments.Find(id).Text = content;
            this.db.Comments.Find(id).Review = review;

            this.db.SaveChanges();
            
        }
    }
}
