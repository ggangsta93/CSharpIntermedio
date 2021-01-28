using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01Sink
{
    class Program
    {
        //TEMA: Interfaz de CallBack
        static void Main(string[] args)
        {
            CRefri miRefri = new CRefri(50, -20);
            Random rnd = new Random();

            //Creamos el Sink
            //Sink1 tiene el codigo que se ejecutara cuando seceda el evento
            CRefriSink sink1 = new CRefriSink();

            //Adicionamos el sink al refri
            miRefri.AgregarSink(sink1);

            //El refri hace su trabajo
            while (miRefri.KilosAlimentos>0)
            {
                //El refri trabaja y le sacamos kilos al azar
                miRefri.trabajar(rnd.Next(1, 15));
            }
        }
    }
}
