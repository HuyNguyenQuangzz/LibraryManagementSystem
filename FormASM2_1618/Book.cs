using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormASM2_1618
{
    class Book
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private int yearofpublication;

        public int Yearofpublication
        {
            get { return yearofpublication; }
            set { yearofpublication = value; }
        }
        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string availability;

        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }
        private static int count = 1;
        public static int Count
        {
            get { return count; }
        }

        public Book(String title, string category, string author, string availability, string publisher, int yearofpublication, string status)
        {
            this.id = count;
            count++;
            this.title = title;
            this.category = category;
            this.author = author;
            this.availability = availability;
            this.publisher = publisher;
            this.yearofpublication = yearofpublication;
            this.status = status;
        }      
    }
}
