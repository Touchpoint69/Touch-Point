using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point.Models
{
  

  public class TeacherCatalog
    {
        private System.Collections.ObjectModel.ObservableCollection<Touch_Point.Teacher> _data;

        public TeacherCatalog()
        {
            _data = new ObservableCollection<Teacher>();
        }

        public ObservableCollection<Teacher> Data { get => _data; set => _data = value; }

        public void Create(Touch_Point.Teacher newStudent)
        {
            _data.Add(newStudent);
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].TeacherID == id)
                {
                    _data.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
