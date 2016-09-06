namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using InheritanceAndPolymorphism.Models;

    public class Course : ICourse
    {
        private const string InvalidCourseName_ExceptionMessage = "Course name cannot be null or empty.";
        private const string InvalidTeacherName_ExceptionMessage = "Teacher name cannot be null or empty.";
        private const string InvalidStudentName_ExceptionMessage = "Student name cannot be null or empty.";

        private string name;
        private string teacherName;
        private IList<string> students;

        protected Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        protected Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        protected Course(string name, string teacherName, IList<string> students)
            : this(name, teacherName)
        {
            this.students = new List<string>();
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidCourseName_ExceptionMessage);
                }

                this.name = value;
            }
        }

        public string TeacherName 
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidTeacherName_ExceptionMessage);
                }

                this.teacherName = value;
            }
        }


        public IList<string> Students { get; private set; }

        public void AddStudents(params string[] students)
        {
            foreach (var student in students)
            {
                if (string.IsNullOrWhiteSpace(student))
                {
                    throw new ArgumentException(InvalidStudentName_ExceptionMessage);
                }

                this.Students.Add(student);
            }
        }

        public string GetStudentsAsString()
        {
            string students = string.Format("{{ {0} }}", string.Join(", ", this.Students));
            return students;
        }

        public override string ToString()
        {
            string courseType = this.GetType().Name;
            string courseName = string.Format("Name = {0}", this.Name);
            string teacherName = string.Format("Teacher = {0}", this.TeacherName);
            string students = string.Empty;

            if (this.Students.Count > 0)
            {
                students = string.Format("Students = {0}", this.GetStudentsAsString());
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(courseType);
            result.AppendLine(courseName);
            result.AppendLine(teacherName);
            result.AppendLine(students);

            return result.ToString().Trim();
        }
    }
}
