﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point.ViewModels.Domain.Course
{
    public class CourseMDVM : INotifyPropertyChanged
    {//Creater nye objekter i systemet
        public CourseMDVM()
        {
            Courses = new ObservableCollection<Touch_Point.Course>();
            Touch_Point.Course C1 = new Touch_Point.Course(11, "Zoneterapi", 12 / 12 / 12, "Jørgen");
            Touch_Point.Course C2 = new Touch_Point.Course(14, "Ninja", 12 / 12 / 12, "Bolette");
            Courses.Add(C1);
            Courses.Add(C2);
        }
        //Det virkede ikke ude disse
        private ObservableCollection<Touch_Point.Course> _courses;
        private Touch_Point.Course _selectedCourse;

        //Contructor for en lister af Courses
        public ObservableCollection<Touch_Point.Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }

        }

        //Metode til at vælge elementer i listen
        public Touch_Point.Course SelectedCourse
        {
            get { return _selectedCourse; }
            set
            {
                _selectedCourse = value;
                OnPropertyChanged();
            }
        }
        //Metode til property changed
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}