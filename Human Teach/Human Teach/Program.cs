using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Teach
{
    class Program
    {
        class Human
        {
            private string firstname;
            private string lastname;
            private string midlename;
            private DateTime birthday;
            public string Firstname
            {
                get { return this.firstname; }
                set { this.firstname = value; }
            }
            public string Lastname
            {
                get { return this.lastname; }
                set { this.lastname = value; }
            }
            public string Midlename
            {
                get { return this.midlename; }
                set { this.midlename = value; }
            }
            public DateTime Birthday
            {
                get { return this.birthday; }
                set { this.birthday = value; }
            }
        }
        class Tutor : Human //тот кто преподает
        { 
        private string listoflessons;
        public void Teach() { }
        }
       abstract class Learner : Human
        {
            private bool iswork;
            public void Study() { }
            public void Work() { }
        }
       class Schoolboy : Learner
       { 
       
       }
       class Student : Learner
       {
           private string firstname;
           private string lastname;
           private string midlename;
           public string Firstname
           {
               get { return this.firstname; }
               set { this.firstname = value; }
           }
           public string Lastname
           {
               get { return this.lastname; }
               set { this.lastname = value; }
           }
           public string Midlename
           {
               get { return this.midlename; }
               set { this.midlename = value; }
           }
       }
        static void Main(string[] args)
        {
        }
    }
}
