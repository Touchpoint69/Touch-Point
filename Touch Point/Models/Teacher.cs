using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point
{
    public class Teacher
    {
        int _teacherID;
        string _name;
        int _SSN;
        string _address;
        int _phone;
        string _email;

        public Teacher(int teacherID, string name, int SSN, string address, int phone, string email)
        {
            _teacherID = teacherID;
            _name = name;
            _SSN = SSN;
            _address = address;
            _phone = phone;
            _email = email;
        }

        public int TeacherID
        {
            get{return _teacherID;}
        }

        public string Name
        {
            get { return _name; }
        }

        public int SSN
        {
            get { return _SSN; }
        }

        public string Address
        {
            get { return _address; }
        }

        public int Phone
        {
            get { return _phone; }
        }

        public string Email
        {
            get { return _email; }
        }

        public override string ToString()
        {
            return _name + " ID Nummer " + _teacherID + "   Telefon: "  + _phone;
        }

        //Teacher aTeacher = new Teacher(01, "Bob", 1234567890, "45th Street Eastside Brooklyn", 12345678, "Bob@Gmail.com");
    }
}
