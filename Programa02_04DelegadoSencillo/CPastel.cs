using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    class CPastel
    {
        //Este metodo actuara como delegado
        public static void mostrarPastel(string pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevara el mensaje {0} ", pAnuncio);
        }
    }
}
