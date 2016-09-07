namespace InheritanceAndPolymorphism
{
    using InheritanceAndPolymorphism.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course : ICourse
    {
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
                    throw new ArgumentException("Course name cannot be null or empty.");
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
                    throw new ArgumentException("Teacher name cannot be null or empty.");
                }

                this.teacherName = value;
            }
        }


        public IList<string> Students { get; private set; }

        /// <summary>
        /// Add students in course. Otherwise if student is null or white space, throws ArgumentException.
        /// </summary>
        /// <param name="students">string[] students</param>
        public void AddStudents(params string[] students)
        {
            foreach (var student in students)
            {
                if (string.IsNullOrWhiteSpace(student))
                {
                    throw new ArgumentException("Student name cannot be null or empty.");
                }

                this.Students.Add(student);
            }
        }

        /// <summary>
        /// Get student and using strin format method.
        /// </summary>
        /// <returns>Converted student as formatted string.</returns>
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
