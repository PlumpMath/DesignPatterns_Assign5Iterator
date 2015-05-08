using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Team Chrono
 * Sam Arutyunyan, Jess Albrecht, James Felts
 */

 /*
 * James Felts
 */
 
namespace DesignPatterns_Assign5Iterator
{
    //ICollection implements IEnumerable<T>
    class Course : ICollection<Student>
    {
        private List<Student> _ListOfStudentsInCourse;

        public Course()
        {
            _ListOfStudentsInCourse = new List<Student>();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new CourseEnumerator(_ListOfStudentsInCourse);
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
            _ListOfStudentsInCourse.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _ListOfStudentsInCourse.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Student item)
        {
            return _ListOfStudentsInCourse.Remove(item);
        }

        private class CourseEnumerator : IEnumerator<Student>
        {
            private List<Student> _ListOfStudentsInCourse;
            private Student _cur;
            private int _curIndex;

            public CourseEnumerator(List<Student> input)
            {
                _ListOfStudentsInCourse = input;
                _curIndex = -1;
                _cur = default(Student);
            }

            public Student Current
            {
                get { return _cur; }
            }

            public void Dispose()
            {}

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                if(++_curIndex >= _ListOfStudentsInCourse.Count)
                {
                    return false;
                }
                else
                {
                    _cur = _ListOfStudentsInCourse[_curIndex];
                }
                return true;

            }

            public void Reset()
            {
                _curIndex = -1;
            }
        }
    }
}
