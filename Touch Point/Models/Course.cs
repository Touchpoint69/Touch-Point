using System;
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
        int _courseID;
        string _name;
        //DateTimeOffset _time;
        string _teacher;


        public Course(int courseID,string name,int sampletid , string teacher)
        {//DateTimeOffset _time
            _courseID = courseID;
            _name = name;
            //Sampletid skal erstattes af datetime
            _teacher = teacher; // teacher skal være objektet teacher ikke en string
        }

        //ObservableCollection<Course> CourseList = new ObservableCollection<Course>();
        //Course C1 = new Course(11,"Zoneterapi",12/12/12,"Jørgen"); 

        public Course()
        {
        }

        public int CourseId
        {
            get { return _courseID; }
        }

        public override string ToString()
        {
            return "This is a " + _name + " Kursus Afholdt af " + _teacher;
        }
    }
}
