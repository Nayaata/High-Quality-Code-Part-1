namespace Abstraction
{
    using Abstraction.Contracts;

    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();
    }
}
