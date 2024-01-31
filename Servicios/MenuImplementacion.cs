using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCompaneroc.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcion;
            Console.WriteLine("Elija la opcion que usted quiera:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Opcion 0. Cerrar menu.");
            Console.WriteLine("Opcion 1. Agregar numero.");
            Console.WriteLine("Opcion 2. Eliminar numero.");
            Console.WriteLine("Opcion 3. Buscar un numero.");
            Console.WriteLine("Opcion 4. Mostrar numeros.");
            opcion = Console.ReadKey().KeyChar-('0');
            return opcion;
        }
    }
}
