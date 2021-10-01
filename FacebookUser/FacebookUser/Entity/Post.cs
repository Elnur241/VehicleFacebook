using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUser.Entity
{
   public  class Post
    {
        public string text;
        public DateTime sharedDate;
        public int likeCount;
        public int commentCount;

        public Comment[] comments;

        public Post()
        {

        }
        public Post(string text, int likeCount)
        {
            this.text = text;
            this.likeCount = likeCount;
        }
        public Post(string text, int likeCount,Comment[] comments)
        {
            this.text = text;
            this.likeCount = likeCount;
        }
    }
}
