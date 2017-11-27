using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point
{
    class Teacher
    {
        int _teacherID;
        string _name;
        int _SSN;
        string _address;
        int _phone;
        string _email;

        public Teacher(int _teacherID, string _name, int _SSN, string _address, int _phone, string _email)
        {
            //_teacherID = teacherID;
            //_name = name;
            //_SSN = SSN;
            //_address = address;
            //_phone = phone;
            //_email = email;
        }
        Teacher aTeacher = new Teacher(01, "Bob", 1234567890, "45th Street Eastside Brooklyn", 12345678, "Bob@Gmail.com");
    }
}
