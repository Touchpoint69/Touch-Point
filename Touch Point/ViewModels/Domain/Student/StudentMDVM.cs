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
        private RelayCommand _updateCommand;
        private RelayCommand _createCommand;

        //Creater nye objekter i systemet
        public StudentMDVM()
        {
            _studentCatalog = new StudentCatalog();
            _studentCatalog.Load();
            //Touch_Point.Student S1 = new Touch_Point.Student(360, "Steven Jobs", 69696969, "MyPhone HQ 420, Vice City", 13371337, "YoMomma@hotmail.com");
            //Touch_Point.Student S2 = new Touch_Point.Student(69, "Will Gates", 42091169, "NanoSoft HQ 911", 14881488, "IEatAss@Yahoo.com");
            //_studentCatalog.Create(S1);
            //_studentCatalog.Create(S2);

            _deletionCommand = new RelayCommand(DeleteStudent, () => _selectedStudent != null);
            _updateCommand = new RelayCommand(UpdateStudent, () => _selectedStudent != null);
            _createCommand = new RelayCommand(CreateStudent, () => true);
        }

        //Skal være der
        private StudentCatalog _studentCatalog;
        private Touch_Point.Student _selectedStudent;

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

        //Contructor for en lister af Students
        public ObservableCollection<Touch_Point.Student> Students
        {
            get { return _studentCatalog.Data; }
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
                _updateCommand.RaiseCanExecuteChanged();
                _createCommand.RaiseCanExecuteChanged();

                if (_selectedStudent != null)
                {
                    Student_ID = _selectedStudent.Student_ID;
                    Name = _selectedStudent.Name;
                    SSN = _selectedStudent.SSN;
                    Address = _selectedStudent.Address;
                    Phone = _selectedStudent.Phone;
                    E_mail = _selectedStudent.E_mail;

                    OnPropertyChanged(nameof(Student_ID));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(SSN));
                    OnPropertyChanged(nameof(Address));
                    OnPropertyChanged(nameof(Phone));
                    OnPropertyChanged(nameof(E_mail));
                }
            }
        }

        public int Student_ID { get; set; }

        public string Name { get; set; }

        public int SSN { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string E_mail { get; set; }


        private void DeleteStudent()
        {
            _studentCatalog.Delete(_selectedStudent.Student_ID);
            OnPropertyChanged(nameof(Students));
        }

        private void UpdateStudent()
        {
            DeleteStudent();
            _studentCatalog.Create(new Touch_Point.Student(Student_ID, Name, SSN, Address, Phone, E_mail));
            OnPropertyChanged(nameof(Students));
        }

        private void CreateStudent()
        {
            _studentCatalog.Create(new Touch_Point.Student(Student_ID, Name, SSN, Address, Phone, E_mail));
            OnPropertyChanged(nameof(Students));
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