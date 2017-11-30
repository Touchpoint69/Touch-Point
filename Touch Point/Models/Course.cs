﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
        //DateTimeOffset _time;
        string _teacher;


        public Course(int courseID,string name,int sampletid , string teacher)
        {//Contructor for et Course objekt
            //DateTimeOffset _time
            _courseID = courseID;
            _name = name;
            //Sampletid skal erstattes af datetime
            _teacher = teacher; // teacher skal være objektet teacher ikke en string
        }

        public Course()
        {
        }

        //******* Til at gøre instacne fieldsne settable for andre klasser
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
        //override metode så det ser godt ud i listen
        public override string ToString()
        {
            return "This is a " + _name + " Kursus Afholdt af " + _teacher;
        }
    }
}
