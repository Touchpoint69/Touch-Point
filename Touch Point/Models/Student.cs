using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point
{
    class Student
    {
        int _studentID;
        string _name;
        int _SSN;
        string _address;
        int _phone;
        string _email;

        public Student(int studentID, string name, int SSN, string address, int phone, string email)
        {
            _studentID = studentID;
            _name = name;
            _SSN = SSN;
            _address = address;
            _phone = phone;
            _email = email;
        }

        Student aTeacher = new Student(01, "Joe", 1234567890, "97th Street Westside Compton", 12345678, "Joe@Gmail.com");

    }
}
