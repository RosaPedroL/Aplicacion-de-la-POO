using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_la_POO
{
    public class Desarrollador : Persona, ICategoria
    {
        List<Proyecto> lista = new List<Proyecto>();
        public Desarrollador(string Nombre, string FechaIngreso, string Email) //agregar al contructos cada desarrollador tiene un numero de proyectos. 
        {
            this.Nombre = Nombre;
            this.FechaIngreso = FechaIngreso;
            this.Email = Email;
        }

        public string Nivel { get; set; }

    }
}
