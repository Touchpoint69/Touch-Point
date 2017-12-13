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

namespace Touch_Point.ViewModels.Domain.Teacher
{
    public class TeacherMDVM : INotifyPropertyChanged
    {
        private RelayCommand _deletionCommand;
        private RelayCommand _updateCommand;
        private RelayCommand _createCommand;

        //Creater nye objekter i systemet
        public TeacherMDVM()
        {
            _teacherCatalog = new TeacherCatalog();
            _teacherCatalog.Load();
            //Touch_Point.Teacher T1 = new Touch_Point.Teacher(1,"Mohammed",0103782037,"Mestervej 4, holbæk",33564784,"Thelord@hotmail.com");
            //Touch_Point.Teacher T2 = new Touch_Point.Teacher(2, "Hanne", 1010104456, "Elisagårdsvej 54, Roskilde", 33554466, "TheSnark@hotmail.com");
            //_teacherCatalog.Create(T1);
            //_teacherCatalog.Create(T2);

            _deletionCommand = new RelayCommand(DeleteTeacher, () => _selectedTeacher != null);
            _updateCommand = new RelayCommand(UpdateTeacher, () => _selectedTeacher != null);
            _createCommand = new RelayCommand(CreateTeacher, () => true);
        }

        //Skal være der
        private TeacherCatalog _teacherCatalog;
        private Touch_Point.Teacher _selectedTeacher;

        public ICommand DeletionCommand
        {
            get { return _deletionCommand; }
        }

        public ICommand UpdateCommand
        {
            get { return _updateCommand; }
        }

        public ICommand CreateCommand
        {
            get { return _createCommand; }
        }

        //Contructor for en lister af Teacher
        public ObservableCollection<Touch_Point.Teacher> Teachers
        {
            get { return _teacherCatalog.Data; }
        }

        //Metode til at vælge elementer i listen
        public Touch_Point.Teacher SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                OnPropertyChanged();
                _deletionCommand.RaiseCanExecuteChanged();
                _updateCommand.RaiseCanExecuteChanged();
                _createCommand.RaiseCanExecuteChanged();

                if (_selectedTeacher != null)
                {
                    Teacher_ID = _selectedTeacher.Teacher_ID;
                    Name = _selectedTeacher.Name;
                    SSN = _selectedTeacher.SSN;
                    Address = _selectedTeacher.Address;
                    Phone = _selectedTeacher.Phone;
                    E_mail = _selectedTeacher.E_mail;

                    OnPropertyChanged(nameof(Teacher_ID));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(SSN));
                    OnPropertyChanged(nameof(Address));
                    OnPropertyChanged(nameof(Phone));
                    OnPropertyChanged(nameof(E_mail));
                }
            }
        }

        public int Teacher_ID { get; set; }

        public string Name { get; set; }

        public int SSN { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string E_mail { get; set; }


        private void DeleteTeacher()
        {
            _teacherCatalog.Delete(_selectedTeacher.Teacher_ID);
            OnPropertyChanged(nameof(Teacher));
        }

        private void UpdateTeacher()
        {
            DeleteTeacher();
            _teacherCatalog.Create(new Touch_Point.Teacher(Teacher_ID, Name, SSN, Address, Phone, E_mail));
            OnPropertyChanged(nameof(Teacher));
        }

        private void CreateTeacher()
        {
            _teacherCatalog.Create(new Touch_Point.Teacher(Teacher_ID, Name, SSN, Address, Phone, E_mail));
            OnPropertyChanged(nameof(Teacher));
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
        // Hvis man ikke bruger databasen skal man bruge dette
        //private ObservableCollection<Touch_Point.Teacher> _TeacherList;
        //private Touch_Point.Teacher _selectedTeacher;
        //private TeacherCatalog _teacherCatalog;

        //public ObservableCollection<Touch_Point.Teacher> TeacherList
        //{
        //    get { return _teacherCatalog.TeacherList; }
        //}