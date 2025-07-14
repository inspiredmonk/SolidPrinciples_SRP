using LSP.Implementatations;
using LSP.Interfaces;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var resolvedDep =  Utility.Resolver("Rectangle");
            //resolvedDep.GetParameters();
            //var calculatedArea =  resolvedDep.CalculateArea();
            //Console.WriteLine(calculatedArea);

            //resolvedDep = Utility.Resolver("Square");
            //resolvedDep.GetParameters();
            //calculatedArea = resolvedDep.CalculateArea();
            //Console.WriteLine(calculatedArea);

            IValidations validations = new Validations();
            byte[] data = new byte[10];
            var fileResolver = Utility.FileResolver("", validations);
            fileResolver.Save("", data);

            fileResolver = Utility.FileResolver("Cloud", validations);
            fileResolver.Save("", data);
        }
    }
}