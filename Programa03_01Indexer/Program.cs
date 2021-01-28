using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            //Creamos la tienda
            CTiendaAutos miTienda = new CTiendaAutos();

            //Obtenemos un auto
            CAuto miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            //Colocamos un auto
            CAuto otroAuto = new CAuto("Vocho", 85000);
            miTienda[1] = otroAuto;

            //Imprimimos toda la tienda
            for (n=0; n<4; n++)
            {
                miTienda[n].MuestraInformacion();
            }
        }
    }
}
