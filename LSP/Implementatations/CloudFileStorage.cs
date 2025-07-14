using LSP.Interfaces;
namespace LSP.Implementatations
{
    public class CloudFileStorage : FileStorage
    {
        public CloudFileStorage(IValidations validations): base(validations)
        { }

        protected override bool isValidationRequired => true;

        public override void Save(string fileName, byte[] data)
        {
            Console.WriteLine($"Saving {fileName} to cloud storage.");
        }
    }
}
