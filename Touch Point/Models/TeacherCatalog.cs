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
        private System.Collections.ObjectModel.ObservableCollection<Touch_Point.Teacher> _data;
        private WebAPISource<Touch_Point.Teacher> _source;

        public TeacherCatalog()
        {
            _data = new ObservableCollection<Teacher>();
            _source = new WebAPISource<Teacher>("http://localhost:2726", "Teachers");
        }

        public ObservableCollection<Teacher> Data { get => _data; set => _data = value; }

        public async void Load()
        {
            List<Teacher> teachersFromDB = await _source.Load();

            foreach (var item in teachersFromDB)
            {
                _data.Add(item);
            }
        }

        public async void Create(Touch_Point.Teacher newTeacher)
        {
            _data.Add(newTeacher);
            await _source.Create(newTeacher);
        }

        public async void Delete(int id)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].Teacher_ID == id)
                {
                    _data.RemoveAt(i);
                    await _source.Delete(id);
                    return;
                }
            }
        }
    }
}
        //public TeacherCatalog()
        //{
        //  _teacherList = new ObservableCollection<Teacher>();
        //}
        //public void Create(Touch_Point.Teacher newTeacher)
        //{
        //    TeacherList.Add(newTeacher);
        //}

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