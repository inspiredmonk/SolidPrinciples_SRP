using LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Implementatations
{
    public class DefaultStorage: FileStorage
    {
        protected override bool isValidationRequired => false;
        public DefaultStorage (IValidations validations): base(validations) { }
    }
}
