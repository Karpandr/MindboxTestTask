namespace MindboxTestTask.Figures
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;
        public double Area => _area.Value;
        public abstract double CalculateArea();
        public Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }
        public abstract void Validate();
    }
}