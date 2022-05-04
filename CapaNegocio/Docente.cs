using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Docente : Persona, IMantenimiento
    {
        // atributos
        private string facultad;
        private string temas;

        // propiedades
        public string Temas { get => facultad; set => facultad = value; }
        public string Facultad { get => temas; set => temas = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}