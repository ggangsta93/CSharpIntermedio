using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_05DelegadoRefri
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefri miRefri = new CRefri(70,-20);
            Random rnd = new Random();

            //Adicionamos los handlers
            miRefri.AdicionarMetodoReservas(new CRefri.DReservasBajas(InformeGrados));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeKilos));

            //El refri trabaja
            while (miRefri.KilosAlimentos>0)
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Se congela el Refri, estoy anivel de main");
            Console.WriteLine("--->Esta {0} grados", pGrados);

        }
    }
}
