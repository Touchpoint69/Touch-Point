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
    class Course : INotifyPropertyChanged
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
        private ObservableCollection<Course> _courses;

        public ObservableCollection <Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
            
        }
        //ObservableCollection<Course> CourseList = new ObservableCollection<Course>();
        //Course C1 = new Course(11,"Zoneterapi",12/12/12,"Jørgen"); 
        
        public void AddCourses()
        {
            //CourseList.Add(C1);
        }

        public Course()
        {
            Courses = new ObservableCollection<Course>();
            Course C1 = new Course(11, "Zoneterapi", 12 / 12 / 12, "Jørgen");
            Course C2 = new Course(11, "Ninja", 12 / 12 / 12, "Bolette");
            Courses.Add(C1);
            Courses.Add(C2);
        }
        public override string ToString()
        {
            return "This is a " + _name + " Kursus Afholdt af " + _teacher;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged
            ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }


    }
}
