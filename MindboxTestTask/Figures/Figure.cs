namespace MindboxTestTask.Figures
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;
        public double Area => _area.Value;
        protected abstract double CalculateArea();
        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }
        protected abstract void Validate();
    }
}