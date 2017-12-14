using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.UserDataTasks.DataProvider;
using Touch_Point.Annotations;
using Touch_Point.Models;

namespace Touch_Point.ViewModels.Domain.Course
{
    public class CourseMDVM : INotifyPropertyChanged
    {
        private RelayCommand _deletionCommand;
        private RelayCommand _updateCommand;
        private RelayCommand _createCommand;

        //Creater nye objekter i systemet
        public CourseMDVM()
        {
            _courseCatalog = new CourseCatalog();
            _courseCatalog.Load();
            //Touch_Point.Course C1 = new Touch_Point.Course(11, "Zoneterapi", 666, new DateTime(2018,1,4,12,0,0,0), "Jørgen");
            //Touch_Point.Course C2 = new Touch_Point.Course(14, "Ninja", 420, new DateTime(2018,1,3,12,0,0), "Bolette");
            //_courseCatalog.Create(C1);
            //_courseCatalog.Create(C2);

            _deletionCommand = new RelayCommand(DeleteCourse, () => _selectedCourse != null);
            _updateCommand = new RelayCommand(UpdateCourse, () => _selectedCourse != null);
            _createCommand = new RelayCommand(CreateCourse, () => true);
        }

        //Det virkede ikke ude disse
        private CourseCatalog _courseCatalog;
        private Touch_Point.Course _selectedCourse;
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

        //Contructor for en lister af Courses
        public ObservableCollection<Touch_Point.Course> Courses
        {
            get { return _courseCatalog.Data; }
        }

        //Metode til at vælge elementer i listen
        public Touch_Point.Course SelectedCourse
        {
            get { return _selectedCourse; }
            set
            {
                _selectedCourse = value;
                OnPropertyChanged();
                _deletionCommand.RaiseCanExecuteChanged();
                _updateCommand.RaiseCanExecuteChanged();
                _createCommand.RaiseCanExecuteChanged();

                if (_selectedCourse != null)
                {
                    Course_ID = _selectedCourse.Course_ID;
                    Title = _selectedCourse.Title;
                    Room = _selectedCourse.Room;
                    Date = _selectedCourse.Date;
                    // Teacher = _selectedCourse.Teacher;


                    OnPropertyChanged(nameof(Course_ID));
                    OnPropertyChanged(nameof(Title));
                    OnPropertyChanged(nameof(Room));
                    OnPropertyChanged(nameof(Date));
                    // OnPropertyChanged(nameof(Teacher_ID));

                }
            }
        }

        public int Course_ID { get; set; }

        public string Title { get; set; }

        public int Room { get; set; }

        public DateTime Date { get; set; }

        public Touch_Point.Teacher SelectedTeacher
        {
            get; set;
        }

        public ObservableCollection<Touch_Point.Teacher> TeacherList
        {
            get
            {
                TeacherCatalog tc = new TeacherCatalog();
                tc.Load();
                return tc.Data;
            }
        }


        private void DeleteCourse()
        {
            _courseCatalog.Delete(_selectedCourse.Course_ID);
            OnPropertyChanged(nameof(Courses));
        }

        private void UpdateCourse()
        {
            DeleteCourse();
            _courseCatalog.Create(new Touch_Point.Course(Course_ID, Title, Room, Date, SelectedTeacher.Name));
            OnPropertyChanged(nameof(Course));
        }

        private void CreateCourse()
        {
            _courseCatalog.Create(new Touch_Point.Course(Course_ID, Title, Room, Date, SelectedTeacher.Name));
            OnPropertyChanged(nameof(Course));
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
