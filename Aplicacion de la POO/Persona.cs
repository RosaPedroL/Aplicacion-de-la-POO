using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_la_POO
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string FechaIngreso { get; set; }
        public string Email { get; set; }
        public Persona()
        {

        }
        public Persona(string Nombre, string FechaIngreso, string Email)
        {
            this.Nombre = Nombre;
            this.FechaIngreso = FechaIngreso;
            this.Email = Email;
        }
        public void datospersona()
        {
            Console.WriteLine(Nombre+" "+FechaIngreso+" "+Email);
        }
    }
}
