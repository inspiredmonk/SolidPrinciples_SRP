using LSP.Implementatations;
using LSP.Interfaces;

namespace LSP
{
    public static class Utility
    {
        public static IAreaCalculator Resolver(string type)
        {
            return type switch { 
                "Rectangle" => (new Rectangle()),
                "Square" => (new Square()),
                "Circle" => (new Circle()),
                _ => null
            }; 
        }

        public static FileStorage FileResolver(string type, IValidations validations)
        {
            return type switch
            {
                "Cloud" => (new CloudFileStorage(validations)),
                _ => (new DefaultStorage(validations))
            };
        }
    }
}
