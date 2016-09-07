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

        /// <summary>
        /// Check which one of two students is older by birth date
        /// </summary>
        /// <param name="otherStudent">Student otherStudent is the second student</param>
        /// <returns>Return true if current student is younger than the other, otherwise return false</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            return this.BirthDate < otherStudent.BirthDate;
        }

    }
}
