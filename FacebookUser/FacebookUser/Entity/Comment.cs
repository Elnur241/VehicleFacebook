using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUser.Entity
{
    public class Comment
    {
        public string text;
        public DateTime commentedDate;

        public User user;
        public Comment()
        {

        }
        public Comment(string text, DateTime commentedDate)
        {
            this.text = text;
            this.commentedDate = commentedDate;
        }
        public Comment(string text, DateTime commentedDate, User user)
        {
            this.text = text;
            this.commentedDate = commentedDate;
        }
    }
}
