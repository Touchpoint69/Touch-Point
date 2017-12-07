using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Touch_Point.Annotations;
using Touch_Point.Models;
using Touch_Point.Views;

namespace Touch_Point.ViewModels.Domain.Student
{
    public class StudentMDVM : INotifyPropertyChanged
    {
        private RelayCommand _deletionCommand;
        //Creater nye objekter i systemet
        public StudentMDVM()
        {
            Students = new ObservableCollection<Touch_Point.Student>();
            Touch_Point.Student S1 = new Touch_Point.Student(360, "Nick Gur", 69696969, "Slavevej 420, Vice City", 13371337, "YoMomma@hotmail.com");
            Touch_Point.Student S2 = new Touch_Point.Student(69, "Per Kjær", 42091169, "Bøssevej 911, Middle of fuckin nowhere", 14881488, "IEatAss@Yahoo.com");
            Students.Add(S1);
            Students.Add(S2);

            _deletionCommand = new RelayCommand(DeleteStudent, () => _selectedStudent != null);
        }

        //Skal være der
        private ObservableCollection<Touch_Point.Student> _students;
        private Touch_Point.Student _selectedStudent;
        public ICommand DeletionCommand
        {
            get { return _deletionCommand; }
        }

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

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
