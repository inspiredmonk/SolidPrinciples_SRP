
using LSP.Interfaces;

namespace LSP.Implementatations
{
    public class Circle : IAreaCalculator
    {
        private float _radius;

        public Circle() { }

        public void GetParameters()
        {
            Console.WriteLine("Please enter radius.");
            _radius = Convert.ToInt64(Console.ReadLine());
        }

        public float CalculateArea()
        {
            return ((22 / 7) * _radius * _radius);
        }
    }
}
