using System.Collections.Generic;

namespace Task1.ClassChef
{
    public class Bowl
    {
        private IList<IVegetable> vegetables;

        public Bowl()
        {
            this.Vegetables = new List<IVegetable>();
        }

        public IList<IVegetable> Vegetables
        {
            get
            {
                return this.vegetables;
            }
            set
            {
                this.vegetables = new List<IVegetable>();
            }
        }

        public void Add(IVegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }
    }
}