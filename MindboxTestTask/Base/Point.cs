namespace MindboxTestTask.Base
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool DoubleEquals(double a, double b)
        {
            return Math.Abs(a - b) < Constants.Eps;
        }

        protected bool Equals(Point other)
        {
            return DoubleEquals(X, other.X) && DoubleEquals(Y, other.Y);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals((Point)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return X.GetHashCode() * 397 ^ Y.GetHashCode();
            }
        }
    }
}
