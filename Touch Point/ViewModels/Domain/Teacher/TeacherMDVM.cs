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

namespace Touch_Point.ViewModels.Domain.Teacher
{
    public class TeacherMDVM : INotifyPropertyChanged
    {
        private RelayCommand _deletionCommand;
        public TeacherMDVM()
        {
            TeacherList = new ObservableCollection<Touch_Point.Teacher>();
            Touch_Point.Teacher T1 = new Touch_Point.Teacher(1,"Mohammed",0103782037,"Mestervej 4, holbæk",33564784,"Thelord@hotmail.com");
            Touch_Point.Teacher T2 = new Touch_Point.Teacher(2, "Hanne", 1010104456, "Elisagårdsvej 54, Roskilde", 33554466, "TheSnark@hotmail.com");
            TeacherList.Add(T1);
            TeacherList.Add(T2);

            _deletionCommand = new RelayCommand(DeleteTeacher, () => _selectedTeacher != null);
        }

        private ObservableCollection<Touch_Point.Teacher> _TeacherList;
        private Touch_Point.Teacher _selectedTeacher;
        public ICommand DeletionCommand
        {
            get { return _deletionCommand; }
        }
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
                _deletionCommand.RaiseCanExecuteChanged();
            }
        }

        private void DeleteTeacher()
        {
            for (int i = 0; i < TeacherList.Count; i++)
            {
                if (TeacherList[i].TeacherID == _selectedTeacher.TeacherID)
                {
                    TeacherList.RemoveAt(i);
                    return;
                }
            }
        }

        //public bool DoDelete()
        //{
        //    return (SelectedTeacher != null && Delete(SelectedTeacher.TeacherID));
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
