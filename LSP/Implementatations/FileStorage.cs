using LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Implementatations
{
    public abstract class FileStorage
    {
        protected abstract bool isValidationRequired { get; }
        private readonly IValidations _validations;

        public FileStorage(IValidations validations) {
            _validations = validations;
        }
        
        public virtual void Save(string fileName, byte[] data)
        {
            if (isValidationRequired)
            {
                _validations.Validate(fileName);
            }
            Console.WriteLine($"Saving {fileName} to local disk.");
        }
    }
}
