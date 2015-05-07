using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Assign5Iterator
{
    class Course : ICollection<Student>
    {
        private List<Student> _ListOfStudentsInCourse;

        public Course()
        {
            _ListOfStudentsInCourse = new List<Student>();
        }


        public IEnumerator<Student> GetEnumerator()
        {
            for(int i = 0;i<_ListOfStudentsInCourse.Count;i++)
            {
                yield return _ListOfStudentsInCourse[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        public void Add(Student item)
        {
            _ListOfStudentsInCourse.Add(item);
        }

        public void Clear()
        {
            _ListOfStudentsInCourse.Clear();
        }

        public bool Contains(Student item)
        {
            return _ListOfStudentsInCourse.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return _ListOfStudentsInCourse.Count; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Student item)
        {
            return _ListOfStudentsInCourse.Remove(item);
        }
    }
}
