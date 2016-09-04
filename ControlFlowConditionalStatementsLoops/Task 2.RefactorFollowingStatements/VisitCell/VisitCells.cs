namespace Task_2.RefactorFollowingStatements.VisitCell
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VisitCells
    {
        private const int Min_X = -50;
        private const int Max_X = 100;
        private const int Min_Y = -50;
        private const int Max_Y = 100;

        public void VisitedCell()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var isXInRange = Min_X <= x && x <= Max_X;
            var isYInRange = Min_Y <= y && y <= Max_Y;
            var isVisited = true;

             if (isXInRange && isYInRange && isVisited)
             {
                VisitCell();
             }
             else
             {
                 Console.WriteLine("The cell cannot be visited!");
             }
        }

        private void VisitCell()
        {
            Console.WriteLine("The cell is correctly visited!");
        }
    }
}
