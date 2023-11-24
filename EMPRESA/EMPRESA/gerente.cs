using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA
{
    //Clase con herencia y utilizano la interfaz
   class gerente:empleado, IMostrarInformacion
    {
        private string departamento;

        public gerente(): base()
        {
            departamento = departamento;
        }
        //Uso de la funcion de la interfaz
        public void mostrarInfo()
        {
            empleado emp1 = new empleado();
            Console.WriteLine("Ingrese el departamento que supervisa:");
            departamento = Console.ReadLine();
            //Llamado a la funcion mostrar informacion de empleado
            emp1.mostrarInfo();
            Console.WriteLine("Deparatamento: " + departamento);

        }
    }
}
