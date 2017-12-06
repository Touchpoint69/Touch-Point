using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point
{
    public class Course
    {
        //Instance Fields
        int _courseID;
        string _name;
        int _room;
        DateTime _time;
        string _teacher;


        public Course(int courseID,string name,int room,int sampletid ,DateTime time, string teacher)
        {//Contructor for et Course objekt
            _time = time;
            _courseID = courseID;
            _name = name;
            _room = room;
            //Sampletid skal erstattes af datetime
            _teacher = teacher; // teacher skal være objektet teacher ikke en string
        }

        public Course()
        {
        }

        //Properties Til at gøre instance fields settable for andre klasser
        public int CourseId
        {
            get { return _courseID; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public int Room
        {
            get { return _room; }
            set { _room = value; }
        }
        //override metode så det ser godt ud i listen
        public override string ToString()
        {
            return "This is a " + _name + " Kursus Afholdt af " + _teacher;
        }
        
    }
}
