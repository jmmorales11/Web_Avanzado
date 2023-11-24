// See https://aka.ms/new-console-template for more information
namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso de un empleado");
            EMPRESA.empleado emp1 = new EMPRESA.empleado();
            emp1.mostrarInfo();
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Ingreso de un Gerente");
            EMPRESA.gerente ger1 = new EMPRESA.gerente();
            ger1.mostrarInfo();
        }
    }
}