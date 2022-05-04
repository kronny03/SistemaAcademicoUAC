using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Administrativo : Persona, IMantenimiento
    {
        // atributos
        private string ambiente;
        private string sueldo;
        
        // propiedades
        public string Ambiente { get => ambiente; set => ambiente = value; }
        public string Sueldo { get => sueldo; set => sueldo = value; }

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