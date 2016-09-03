namespace Task_2.RefactorFollowingStatements
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var cooker = new Cooker();
            var potato = new Potato();

            cooker.CheckIfPotatoIsReadyForCooking(potato);
        }
    }
}
