using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Touch_Point.Models;

namespace Touch_Point
{
    public class Student
    {
        int _student_ID;
        string _name;
        int _SSN;
        string _address;
        int _phone;
        string _e_mail;

        public Student(int student_ID, string name, int SSN, string address, int phone, string e_mail)
        {
            _student_ID = student_ID;
            _name = name;
            _SSN = SSN;
            _address = address;
            _phone = phone;
            _e_mail = e_mail;
        }

        public int Student_ID
        {
            get { return _student_ID; }
            set { _student_ID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string E_mail
        {
            get { return _e_mail; }
            set { _e_mail = value; }
        }

        public override string ToString()
        {
            return _name + " ID Nummer " + _student_ID + "   Telefon: " + _phone;
        }
    }
}
        //Student aStudent = new Student(01, "Joe", 1234567890, "97th Street Westside Compton", 12345678, "Joe@Gmail.com");