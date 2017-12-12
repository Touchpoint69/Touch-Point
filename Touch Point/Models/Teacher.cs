using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Touch_Point.Models;

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
            set { _teacherID = value; }
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

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public override string ToString()
        {
            return _name + " ID Nummer " + _teacherID + "   Telefon: "  + _phone;
        }
    }
}
