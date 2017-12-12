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
        string _title;
        int _location;
        DateTime _time;
        string _teacher;

        public Course(int courseID,string title,int location,DateTime time, string teacher)
        {//Contructor for et Course objekt
            _courseID = courseID;
            _title = title;
            _location = location;
            _time = time;
            //Sampletid skal erstattes af datetime
            _teacher = teacher; // teacher skal være objektet teacher ikke en string
        }

        //Properties Til at gøre instance fields settable for andre klasser
        public int CourseID
        {
            get { return _courseID; }
            set { _courseID = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        //override metode så det ser godt ud i listen
        public override string ToString()
        {
            return "This is a " + _title + " Kursus Afholdt af " + _teacher;
        }
    }
}
