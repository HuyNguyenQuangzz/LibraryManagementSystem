using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormASM2_1618
{
    class Reader
    {
        private int idreader;

        public int Idreader
        {
            get { return idreader; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string numberOfBookBorrowed;
        public string NumberOfBookBorrowed
        {
            get { return numberOfBookBorrowed; }
            set { numberOfBookBorrowed = value; }
        }
        private static int count = 1;
        public static int Count
        {
            get { return count; }
        }
        public Reader(string name,string address, string gender, string phone, string numberOfBookBorrowed)
        {
            this.idreader = count;
            count++;
            this.name = name;
            this.address = address;
            this.gender = gender;
            this.phone = phone;
            this.numberOfBookBorrowed = numberOfBookBorrowed;
        }


    }
}
