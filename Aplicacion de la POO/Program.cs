using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_la_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Desarrollador desarrollador1 = new Desarrollador("Fernando", "12/02/23", "qr@gmail.com");
            desarrollador1.datospersona();
            Console.ReadLine();//ejecuta la consola- 
        }
    }
}
