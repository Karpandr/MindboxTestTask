using MindboxTestTask.Base;

namespace MindboxTestTask.Figures
{
    public class Triangle : Figure
    {
        private readonly Lazy<bool> _isRightAngled;
        public bool IsRightAngled => _isRightAngled.Value;
        public Side SideA { get; }
        public Side SideB { get; }
        public Side SideC { get; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            SideA = new Side(x1, y1, x2, y2);
            SideB = new Side(x2, y2, x3, y3);
            SideC = new Side(x3, y3, x1, y1);
            _isRightAngled = new Lazy<bool>(SolveIsRightAngle);
            Validate();
        }

        public override double CalculateArea()
        {
            var halfPerimeter = 0.5 * (SideA.Length + SideB.Length + SideC.Length);
            var area = Math.Sqrt(halfPerimeter
                * (halfPerimeter - SideA.Length)
                * (halfPerimeter - SideB.Length)
                * (halfPerimeter - SideC.Length));
            return area;
        }

        private bool SolveIsRightAngle()
        {
            var orderedSides = new List<Side>() { SideA, SideB, SideC }.OrderByDescending(x => x.Length).ToList();
            var isRight = Math.Abs(Math.Pow(orderedSides[0].Length, 2)
                                    - Math.Pow(orderedSides[1].Length, 2)
                                    - Math.Pow(orderedSides[2].Length, 2)) < Constants.Eps;
            return isRight;
        }

        protected bool Equals(Triangle other)
        {
            var mySides = new HashSet<Side>() { SideA, SideB, SideC };
            var otherSides = new HashSet<Side>() { other.SideA, other.SideB, other.SideC };
            return mySides.SetEquals(otherSides);
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
                return SideA.GetHashCode() + SideB.GetHashCode() + SideC.GetHashCode();
            }
        }

        /// <summary>
        /// Если псевдоскалярное произведение векторов равно нулю, то все три точки лежат на одной прямой.
        /// Следовательно, треугольника с такими координатами не существует.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public override void Validate()
        {
            var vectorPseudoscalarMulti = (SideA.End.X - SideA.Start.X) * (SideC.End.Y - SideC.Start.Y)
                - (SideA.End.Y - SideA.Start.Y) * (SideC.End.X - SideC.Start.X);
            if (Math.Abs(vectorPseudoscalarMulti) < Constants.Eps)
                throw new ArgumentException("Triangle with such coordinates doesn't exist");
        }

    }
}
