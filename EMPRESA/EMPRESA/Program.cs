// See https://aka.ms/new-console-template for more information
namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso de un empleado");
            //Creacion del objeto empleado
            EMPRESA.empleado emp1 = new EMPRESA.empleado();
            //Llamado a la funcion mostrar informacion de empleado
            emp1.mostrarInfo();
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Ingreso de un Gerente");
            //Creacion del objeto gerente
            EMPRESA.gerente ger1 = new EMPRESA.gerente();
            //Llamado ala funncion del objeto gerente 
            ger1.mostrarInfo();
        }
    }
}