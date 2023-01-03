namespace MindboxTestTask.Base
{
    public class Side
    {
        private readonly Lazy<double> _length;
        public double Length => _length.Value;
        public Point Start { get; }
        public Point End { get; }

        public Side(double startX, double startY, double endX, double endY)
        {
            Start = new Point(startX, startY);
            End = new Point(endX, endY);
            _length = new Lazy<double>(CalculateLength);
        }

        public double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
        }

        protected bool Equals(Side other)
        {
            return Start.Equals(other.Start) && End.Equals(other.End) 
                || Start.Equals(other.End) && End.Equals(other.Start);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals((Side)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return Start.GetHashCode() ^ End.GetHashCode();
            }
        }
    }
}
