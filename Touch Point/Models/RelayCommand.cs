using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Touch_Point.ViewModels.Domain.Teacher;
using Touch_Point.ViewModels.Domain.Student;
using Touch_Point.ViewModels.Domain.Course;

namespace Touch_Point.Models
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        private Teacher teacher;
        private Course course;
        private Student student;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Teacher teacher)
        {
            this.teacher = teacher;
        }

        public RelayCommand(Student student)
        {
            this.student = student;
        }
        public bool CanExecute(object parameter)
        {
            return ((_canExecute == null) || _canExecute());
        }

        public void Execute(object parameter)
        {
            _execute();
            
        }
        
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
