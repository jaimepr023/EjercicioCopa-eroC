using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCompaneroc.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
       
        public void agregar(ArrayList lista)
        {
            string variable =  "22";
            variable = Console.ReadLine();
            long numero = Int64.Parse(variable);
            lista.Add(numero);
        }

        public void borrar(ArrayList lista)
        {
           
            if (lista.Count > 0) 
            {
                Console.WriteLine("Deme el numero que quiera eliminar");
                int numeliminar = Int32.Parse(Console.ReadLine());
                if(lista.IndexOf(numeliminar)>=0)
                {
                    lista.Remove(numeliminar);
                }
                else
                {
                    Console.WriteLine("El numero no se encuentra en la lista");
                }

            }else
            {
                Console.WriteLine("La lista no tiene elementos, agrege alguno para poder utilizar esta opcion");
            }
        }

        public void buscar(ArrayList lista)
        {
            if (lista.Count > 0)
            {
                Console.WriteLine("Deme el numero que quiera eliminar");
                int numbuscar = Int32.Parse(Console.ReadLine());
                if (lista.IndexOf(numbuscar) >= 0)
                {
                    Console.WriteLine("El numero: " +numbuscar+ " se encuentra en la posicion " + lista.IndexOf(numbuscar));
                }
                else
                {
                    Console.WriteLine("El numero no se encuentra en la lista");
                }

            }
            else
            {
                Console.WriteLine("La lista no tiene elementos, agrege alguno para poder utilizar esta opcion");
            }

        }

       
    }
}
