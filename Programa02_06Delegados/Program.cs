using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_06Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //Variables para el multicasting, necesitamos la instancia para poder adicionar o eliminar
            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

            DDescongelado desc1 = new DDescongelado(InformeGrados);

            //Adicionamos los handlers
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(desc1);

            //El refri trabaja
            while (miRefri.KilosAlimentos > 0)
            {
                miRefri.trabajar(rnd.Next(1, 5));
            }

            //Eliminamos un handler
            miRefri.EliminarMetodoReservas(kilos2);

            /////////////////////////////////

            //Rellenamos el refri
            miRefri.KilosAlimentos = 50;
            miRefri.Grados = -15;

            while (miRefri.KilosAlimentos > 0)
            {
                miRefri.trabajar(rnd.Next(1, 5));
            }


        }

        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Reservas bajas de alimentos, estoy anivel de main");
            Console.WriteLine("--->Quedan {0} kilos", pKilos);
        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---> Se congela el Refri, estoy anivel de main");
            Console.WriteLine("--->Esta {0} grados", pGrados);

        }
    }
}
