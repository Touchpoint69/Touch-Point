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
        int _course_ID;
        string _title;
        int _room;
        int _date;
        string _teacher_ID;

        public Course(int course_ID,string title,int room,int date, string teacher_ID)
        {//Contructor for et Course objekt
            _course_ID = course_ID;
            _title = title;
            _room = room;
            _date = date;
            //Sampletid skal erstattes af datetime
            _teacher_ID = teacher_ID; // teacher skal være objektet teacher ikke en string
        }

        //Properties Til at gøre instance fields settable for andre klasser
        public int Course_ID
        {
            get { return _course_ID; }
            set { _course_ID = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Room
        {
            get { return _room; }
            set { _room = value; }
        }

        public int Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Teacher_ID
        {
            get { return _teacher_ID; }
            set { _teacher_ID = value; }
        }

        //override metode så det ser godt ud i listen
        public override string ToString()
        {
            return "This is a " + _title + " Kursus Afholdt af " + _teacher_ID;
        }
    }
}
