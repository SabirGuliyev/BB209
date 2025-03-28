using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInClassExample.Models
{
    internal class Group
    {
        private Student[] _students;

        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }
        public string Name { get; set; }

        public Group(string name)
        {
            Name= name;
            _students= new Student[0];
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length-1]= student;
        }
        public void ShowStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].GetInfo();
            }
        }

        public Student GetStudent(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                //turane         //turane
                if (Students[i].Name.ToLower() == name.ToLower())
                {
                    return Students[i];
                }
            }
            return null;
        }

        public void DeleteStudent(string name)
        {
            //ali, rza, sexavet
            // 0    1     2
            // "Ali", "Sexavet"
            // 0       1

            Student[] arr = new Student[Students.Length - 1];

            int j = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name.ToLower() != name.ToLower())
                {
                    arr[j] = Students[i];
                    j++;
                }
            }

            Students = arr;

        }

    }
}
