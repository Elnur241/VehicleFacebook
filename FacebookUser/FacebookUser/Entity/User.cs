using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUser.Entity
{
    public class User
    {
        public string name;
        public string surname;
        public string email;
        public int dateOfBirth;
        public Boolean isSingle ;

        public Post[] posts;

        
        public User()
        {

        }
        public User(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public User(string name, string surname,Post[] posts)
        {
            this.name = name;
            this.surname = surname;
            this.posts = posts;
         
        }

    }
}
