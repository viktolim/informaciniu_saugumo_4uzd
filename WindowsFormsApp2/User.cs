using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class User
    {

        protected string username;
        protected string userpassword;

        protected string comment;
        protected string name;
        protected string url;
        protected string password;
        public User()
        {

        }
        public User(string username,string password)
        {
            this.username = username;
            this.userpassword = password;
    }
        public void created(string comment, string name, string url)
        {
            this.comment = comment;
            this.name = name;
            this.url = url;
        }
        public string getUsername()
        {
            return username;
        }
        public string getUserPassword()
        {
            return userpassword;
        }
        public string getComment()
        {
            return this.comment;
        }
        public string getName()
        {
            return this.name;
        }
        public string getUrl()
        {
            return this.url;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
