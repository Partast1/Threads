using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTraining
{
    public abstract class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private Person publisher;

        public Person Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public Book(){}
        public Book(string tit,string desc,Person pub)
        {
            title = tit;
            description = desc;
            publisher = pub;
        }

    }
}
