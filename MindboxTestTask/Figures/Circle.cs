using MindboxTestTask.Base;

namespace MindboxTestTask.Figures
{
    public class Circle : Figure
    {
        public Point Center { get; }
        public double Radius { get; }
        public Circle(double x, double y, double radius)
        {
            Center = new Point(x, y);
            Radius = radius;
            Validate();
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        protected bool Equals(Circle other)
        {
            return Center.Equals(other.Center) && Radius == other.Radius;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals((Triangle)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return Center.GetHashCode() * 397 ^ Radius.GetHashCode();
            }
        }

        public override void Validate()
        {
            if (Radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }
    }
}
