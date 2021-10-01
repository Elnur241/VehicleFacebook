using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookUser.Entity;

namespace FacebookUser
{
    class Program
    {
        static void Main(string[] args)
        {  
            Comment comment = new Comment("Bu menim commentimdir", DateTime.Now);
            Comment comment2 = new Comment("Bu senim commentimdir", DateTime.Now);
            Comment[] comments = { comment, comment2 };
            Post post = new Post("facebook", 123, comments);
            Post post1 = new Post("instagram", 500);
            Post post2 = new Post("telegram", 35);
            Post[] posts = { post, post1, post2 };
            User user = new User("Elnur", "Ilyasli", posts);
            comment.user = user;
            user.posts = posts;
            Console.WriteLine(comment.user.posts[0].text);
            Console.ReadKey();

        }
    }
}
