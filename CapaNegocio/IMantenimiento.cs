using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    interface IMantenimiento
    {
        // Una interfaz es una semi clase declarativa de metodos abstractos
        bool Agregar();
        bool Eliminar();
        bool Actualizar();
        string Listar();
        string Buscar();

    }
}
