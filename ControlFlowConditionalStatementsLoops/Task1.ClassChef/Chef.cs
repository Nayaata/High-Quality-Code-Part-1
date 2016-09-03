namespace Task1.ClassChef
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();

            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            var newBowl = new Bowl();

            return newBowl;
        }
        private Carrot GetCarrot()
        {
            var newCarrot = new Carrot();

            return newCarrot;
        }
        private Potato GetPotato()
        {
            var newPotato = new Potato();

            return newPotato;
        }

        private void Cut(IVegetable vegetable)
        {
            vegetable.IsCutted = true;
        }

        private void Peel(IVegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

    }
}
