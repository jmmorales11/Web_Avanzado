using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA
{
    //Creacion de la clase base empleado
    class empleado:IMostrarInformacion
    {
        //Atributos de la clase empleado
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string cedula { get; set; }
        private float sueldo { get; set; }
        private int mes { get; set; }
        //Constructor de la clase empleado
       public empleado()
        {
            nombre = nombre;
            apellido = apellido;
            cedula = cedula;
            sueldo=sueldo;
            mes= mes;   
        }

        public void mostrarInfo()
        {
            //Insercion de datos
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de Cedula:");
            cedula = Console.ReadLine();
            sueldo=salarioAnual();
            //Impresion de datos
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Datos Ingresados");
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Sueldo Anual: " +sueldo );
        }
        //Funcion para calcular el salrio anual del empleado
        public float salarioAnual()
        {
           Console.WriteLine("Igreso del sueldo mensual:");
           String sueldo1 = Console.ReadLine();
            sueldo = float.Parse(sueldo1);
            return sueldo * 12;
        }

    }
}
