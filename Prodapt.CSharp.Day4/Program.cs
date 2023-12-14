using Prodapt.CSharp.Library;
namespace Prodapt.CSharp.Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginValidation obj = new LoginValidation();
            var result = obj.Validation("admin", "admin@123");
            Console.WriteLine(result ? "Valid User" : "Invalid User");
        }
    }
}
