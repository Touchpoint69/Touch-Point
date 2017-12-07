using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Touch_Point.Models;
using Touch_Point.Annotations;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.UserDataTasks.DataProvider;

namespace Touch_Point.ViewModels.Domain.Student
{
    public class StudentMDVM : INotifyPropertyChanged
    {
        private RelayCommand _deletionCommand;
        //Creater nye objekter i systemet
        public StudentMDVM()
        {
            Students = new ObservableCollection<Touch_Point.Student>();
            Touch_Point.Student S1 = new Touch_Point.Student(1, "Mohammed", 0103782037, "Mestervej 4, holbæk", 33564784, "Thelord@hotmail.com");
            Touch_Point.Student S2 = new Touch_Point.Student(1,"Mohammed",0103782037,"Mestervej 4, holbæk",33564784,"Thelord@hotmail.com");
            Students.Add(S1);
            Students.Add(S2);

            _deletionCommand = new RelayCommand(DeleteStudent, () => _selectedStudent != null);
        }

        public ICommand DeletionCommand
        {
            get { return _deletionCommand; }
        }
        //Det virkede ikke ude disse
        private ObservableCollection<Touch_Point.Student> _students;
        private Touch_Point.Student _selectedStudent;

        //Contructor for en lister af Students
        public ObservableCollection<Touch_Point.Student> Students
        {
            get { return _students; }
            set { _students = value; }

        }

        //Metode til at vælge elementer i listen
        public Touch_Point.Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
                _deletionCommand.RaiseCanExecuteChanged();
            }
        }
        private void DeleteStudent()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentID == _selectedStudent.StudentID)
                {
                    Students.RemoveAt(i);
                    return;
                }
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
