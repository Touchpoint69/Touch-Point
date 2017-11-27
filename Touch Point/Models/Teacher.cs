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

        public Teacher(int _teacherID,string _name,int _SSN,string _address,int _phone,string _email)
        {

        }
        Teacher T1 = new Teacher(1, "jørgen", 1234562222, "wayofthefist 222", 22334455, "Theman@gmail.com");
    }
}
