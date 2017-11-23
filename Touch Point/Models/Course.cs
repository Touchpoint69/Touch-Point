using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point
{
    class Course : INotifyPropertyChanged
    {
        int _courseID;
        string _name;
        DateTimeOffset _time;
        string _teacher;

        public event PropertyChangedEventHandler PropertyChanged;

        public Course(int _courseID,string _name, DateTimeOffset _time, string _teacher)
        {
            
        }
        public List <string> Courses
        {
            get { return Courses; }
            
        }
        


    }
}
