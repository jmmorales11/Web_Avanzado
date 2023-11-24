using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA
{
   class gerente:empleado, IMostrarInformacion
    {
        private string departamento;

        public gerente(): base()
        {
            departamento = departamento;
        }

        public void mostrarInfo()
        {
            empleado emp1 = new empleado();
            Console.WriteLine("Ingrese el departamento que supervisa:");
            departamento = Console.ReadLine();
            emp1.mostrarInfo();
            Console.WriteLine("Deparatamento: " + departamento);

        }
    }
}
