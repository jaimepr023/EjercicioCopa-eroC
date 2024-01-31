using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCompañeroc.Servicios
{
    internal interface OperacionesInterfaz
    {
        public void agregar(ArrayList lista);

        public void borrar(ArrayList lista);

        public void buscar(ArrayList lista);
    }
}
