using LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Implementatations
{
    public class Validations: IValidations
    {
        public Validations() { }
        public void Validate(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new Exception("Cloud storage requires a file name!");
            }
        }
    }
}
