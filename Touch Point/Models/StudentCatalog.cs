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
        private WebAPISource<Touch_Point.Student> _source;

        public StudentCatalog()
        {
            _data = new ObservableCollection<Student>();
            _source = new WebAPISource<Student>("http://localhost:2726", "Students");
        }

        public ObservableCollection<Student> Data { get => _data; set => _data = value; }

        public async void Load()
        {
            List<Student> studentsFromDB = await _source.Load();

            foreach (var item in studentsFromDB)
            {
                _data.Add(item);
            }
        }

        public async void Create(Touch_Point.Student newStudent)
        {
            _data.Add(newStudent);
            await _source.Create(newStudent);
        }

        public async void Delete(int id)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].Student_ID == id)
                {
                    _data.RemoveAt(i);
                    await _source.Delete(id);
                    return;
                }
            }
        }
    }
}