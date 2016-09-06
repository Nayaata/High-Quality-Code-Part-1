namespace Task1.QualityMethods.Models
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDate, string town)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }


        public bool IsOlderThan(Student other)
        {
            return this.BirthDate < other.BirthDate;
        }

    }
}
