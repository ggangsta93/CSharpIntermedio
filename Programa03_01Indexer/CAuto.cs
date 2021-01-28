using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01Indexer
{
    class CAuto
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            //Inicializamos 
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            //Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}",modelo);
            Console.WriteLine("Costo {0}",costo);
            Console.WriteLine("--------------");
        }
    }
}
