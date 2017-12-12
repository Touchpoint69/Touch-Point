using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point.Models
{
    class CourseCatalog
    {
        private System.Collections.ObjectModel.ObservableCollection<Touch_Point.Course> _data;

        public CourseCatalog()
        {
            _data = new ObservableCollection<Course>();
        }

        public ObservableCollection<Course> Data { get => _data; set => _data = value; }

        public void Create(Touch_Point.Course newCourse)
        {
            _data.Add(newCourse);
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].CourseID == id)
                {
                    _data.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
