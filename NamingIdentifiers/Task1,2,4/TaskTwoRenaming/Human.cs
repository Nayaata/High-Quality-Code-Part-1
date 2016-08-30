namespace People
{
    public class Human
    {
        public GenderType Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static Human HumanFactory(int personalNumber)
        {
            var newHuman = new Human();

            newHuman.Age = personalNumber;

            if (newHuman.Age % 2 == 0)
            {
                newHuman.Name = "Cute Dude";
                newHuman.Gender = GenderType.Male;
            }
            else
            {
                newHuman.Name = "Sexy Lady";
                newHuman.Gender = GenderType.Female;
            }

            return newHuman;
        }
    }
}
