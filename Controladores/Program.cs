using EjercicioCompañeroc.Servicios;
using System.Collections;

namespace EjercicioCompañeroc.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            MenuInterfaz mi = new MenuImplementacion();
            OperacionesInterfaz op = new OperacionesImplementacion();
            int opcionMenu;
            bool cerrarMenu = false;
            do
            {
                opcionMenu = mi.mostrarMenu();
                Console.WriteLine();
                switch (opcionMenu)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        op.agregar(lista);
                        break;
                    case 2:
                        op.borrar(lista);
                        break;
                    case 3:
                        op.buscar(lista);
                        break;
                    case 4:
                        foreach (var item in lista)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        Console.WriteLine("No has elegido ninguna opcion");
                        break;
                }
            }while(!cerrarMenu);

        }
    }
}