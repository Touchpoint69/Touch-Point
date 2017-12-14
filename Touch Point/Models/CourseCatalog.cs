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
        private WebAPISource<Touch_Point.Course> _source;

        public CourseCatalog()
        {
            _data = new ObservableCollection<Course>();
            _source = new WebAPISource<Course>("http://localhost:2726", "Courses");
        }

        public ObservableCollection<Course> Data { get => _data; set => _data = value; }

        public async void Load()
        {
            List<Course> coursesFromDB = await _source.Load();

            foreach (var item in coursesFromDB)
            {
                _data.Add(item);
            }
        }

        public async void Create(Touch_Point.Course newCourse)
        {
            _data.Add(newCourse);
            await _source.Create(newCourse);
        }

        public async void Delete(int id)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].Course_ID == id)
                {
                    _data.RemoveAt(i);
                    await _source.Delete(id);
                    return;
                }
            }
        }
    }
}
