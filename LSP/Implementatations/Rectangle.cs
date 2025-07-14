using LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Implementatations
{
    public class Rectangle: IAreaCalculator
    {
        private float _height;
        private float _width;

        public Rectangle() { }

        public void GetParameters()
        {
            Console.WriteLine("Please enter width.");
            _width = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please enter height.");
            _height = Convert.ToInt64(Console.ReadLine());
        }

        public float CalculateArea()
        {
            return _height * _width;
        }

    }
}
