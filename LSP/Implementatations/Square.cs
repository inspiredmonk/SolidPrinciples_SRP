using LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Implementatations
{
    public class Square : IAreaCalculator
    {
        private float _height;
        private float _width;

        public Square() { }

        public void GetParameters()
        {
            Console.WriteLine("Please enter width/height.");
            _height = _width = Convert.ToInt64(Console.ReadLine());
        }

        public float CalculateArea()
        {
            return _height * _width;
        }
    }
}
