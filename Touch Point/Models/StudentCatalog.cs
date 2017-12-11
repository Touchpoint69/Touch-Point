using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point.Models
{
    class StudentCatalog
    {
        private System.Collections.ObjectModel.ObservableCollection<Touch_Point.Student> _data;

        public StudentCatalog()
        {
            _data = new ObservableCollection<Student>();
        }

        public ObservableCollection<Student> Data { get => _data; set => _data = value; }

        public void Create(Touch_Point.Student newStudent)
        {
            _data.Add(newStudent);
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].StudentID == id)
                {
                    _data.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
