using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_05DelegadoRefri
{
    class CRefri
    {
        //Aqui van los delegados
        public delegate void DReservasBajas(int pKilos);
        public delegate void DDescongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        //Aqui estan las variables que usaremos para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;
        
        public CRefri(int pKilos, int pGrados)
        {
            //Coloca los valores iniciales del refri
            KilosAlimentos = pKilos;
            Grados = pGrados;
        }

        //Estos metodos permiten referencias las variables
        public void AdicionarMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado = pMetodo;
        }

        //Propiedades necesarias
        public int KilosAlimentos { get => kilosAlimentos; set => kilosAlimentos = value; }
        public int Grados { get => grados; set => grados = value; }

        public void trabajar(int pConsumo)
        {
            //Actulizamos los kilos del refri
            kilosAlimentos -= pConsumo;

            //Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //Hay que verificar si se cumple para
            //invocar los handlers del evento

            //Esta es la condicion del evento para los kilos
            if (kilosAlimentos < 10)
            {
                //Invocamos el metodo
                delReservas(kilosAlimentos);
            }

            //Esta es la condicion del evento para la temperatura
            if (grados > 0)
            {
                //Invocamos el metodo
                delDescongelado(grados);
            }
        }
    }
}
