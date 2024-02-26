using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_la_POO
{
    class Proyecto : ICategoria
    {
        public string Nombre { get; set; }
        public string FechaInicio { get; set; }
        public int DuracionHora { get; set; }
        public string Nivel { get; set; }
        public int CantidadHora { get; set; }

        public Proyecto() { }

        public Proyecto(string nombre, string fechaInicio, int duracionHora)
        {
            Nombre = nombre;
            FechaInicio = fechaInicio;
            DuracionHora = duracionHora;
        }

        
    }
}
