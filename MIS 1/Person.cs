using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIS
{
    public class Person
    {
        private string id;
        private string name;
        private string lesson;
        private string grade;
        private string tele;
        private string email;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       

        public string Lesson
        {
            get { return lesson; }
            set { lesson = value; }
        }
      

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string Tele
        {
            get{return tele;}
            set{tele=value;}
        }
        public string Email
        {
            get{return email;}
            set { email = value; }
        }
    }
}
