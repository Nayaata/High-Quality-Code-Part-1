namespace TaskTwoRenaming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class People
    {
        class Human
        {
            public GenderType Gender { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }
        public void HumanFactory(int personalNumber)
        {
            Human newHuman = new Human();

            newHuman.age = personalNumber;

            if (personalNumber % 2 == 0)
            {
                newHuman.name = "Cute Dute";
                newHuman.Gender = Gender.Men;
            }
            else
            {
                newHuman.name = "Sexy Lady";
                newHuman.Gender = Gender.Women;
            }
        }
    }
}
