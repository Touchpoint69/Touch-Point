using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Touch_Point.Annotations;

namespace Touch_Point.ViewModels.Domain.Teacher
{
    public class TeacherMDVM : INotifyPropertyChanged
    {
        public TeacherMDVM()
        {
            TeacherList = new ObservableCollection<Touch_Point.Teacher>();
            Touch_Point.Teacher T1 = new Touch_Point.Teacher(1,"Mohammed",0103782037,"Mestervej 4, holbæk",33564784,"Thelord@hotmail.com");
            Touch_Point.Teacher T2 = new Touch_Point.Teacher(2, "Hanne", 1010104456, "Elisagårdsvej 54, Roskilde", 33554466, "TheSnark@hotmail.com");
            TeacherList.Add(T1);
            TeacherList.Add(T2);
        }
        private ObservableCollection<Touch_Point.Teacher> _TeacherList;
        private Touch_Point.Teacher _selectedTeacher;

        public ObservableCollection<Touch_Point.Teacher> TeacherList
        {
            get { return _TeacherList; }
            set { _TeacherList = value; }

        }

        public Touch_Point.Teacher SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                OnPropertyChanged();
            }
        }
        //        private ObservableCollection<Touch_Point.Teacher> _teachers;
        //        public ObservableCollection<Touch_Point.Teacher> Teachers
        //        {
        //            get { return _teachers; }
        //            
        //        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
