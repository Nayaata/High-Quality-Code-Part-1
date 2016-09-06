namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var localCourse = new LocalCourse("JS OOP", "Doncho Minkov", new List<string>() { "Pesho", "Gosho", "Tosho" }, "Enterprise Lab");
            Console.WriteLine(localCourse);

            localCourse.Students.Add("Neda");
            localCourse.Students.Add("Andrea");

            Console.WriteLine(localCourse);

            var offsiteCourse = new OffsiteCourse("JS APPs", "Doncho Minkov", new List<string>() { "Jhon", "Jane", "Mark" }, "Sofia Lab");
            Console.WriteLine(offsiteCourse);
        }
    }
}