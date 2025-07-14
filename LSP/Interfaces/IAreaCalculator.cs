using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Interfaces
{
    public interface IAreaCalculator
    {
        void GetParameters();
        float CalculateArea();
    }
}
