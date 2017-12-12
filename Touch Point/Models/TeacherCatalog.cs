using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch_Point.Models
{
  

   class TeacherCatalog
    {
        private System.Collections.ObjectModel.ObservableCollection<Touch_Point.Teacher> _teacherList;
        public ObservableCollection<Teacher> TeacherList { get => _teacherList; set => _teacherList = value; }
        public TeacherCatalog()
        {
          _teacherList = new ObservableCollection<Teacher>();
        }
        public void Create(Touch_Point.Teacher newTeacher)
        {
            TeacherList.Add(newTeacher);
        }
        public void DeleteTeacher(int id)
        {
            for (int i = 0; i < _teacherList.Count; i++)
            {
                if (_teacherList[i].TeacherID == id)
                {
                    _teacherList.RemoveAt(i);
                    return;
                }
            }
        }
        //private System.Collections.ObjectModel.ObservableCollection<Touch_Point.Teacher> _data;

        //public TeacherCatalog()
        //{
        //    _data = new ObservableCollection<Teacher>();
        //}

        //public ObservableCollection<Teacher> Data { get => _data; set => _data = value; }

        //public void Create(Touch_Point.Teacher newStudent)
        //{
        //    _data.Add(newStudent);
        //}

        //public void Delete(int id)
        //{
        //    for (int i = 0; i < _data.Count; i++)
        //    {
        //        if (_data[i].TeacherID == id)
        //        {
        //            _data.RemoveAt(i);
        //            return;
        //        }
        //    }
        //}
    }
}
