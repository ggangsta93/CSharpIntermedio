using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02SinkMultiple
{
    class CRefri
    {
        //Aquí guardamos todos los sinks con los que se comunicara el refri
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimentos = 0;
        private int grados = 0;

        public CRefri(int pKilos, int pGrados)
        {
            //Coloca los valores iniciales del refri
            KilosAlimentos = pKilos;
            Grados = pGrados;
        }

   
        //Con este metodo adicionamos un sink
        public void AgregarSink(IEventoRefri pSink)
        {
            if (pSink != null)
            {
                listaSinks.Add(pSink);
            }
        }

        //Con este metodo eliminamos un sink
        public void EliminarSink(IEventoRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
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

            //Esta es la condicion del evento
            if (kilosAlimentos <10)
            {
                //Invocamos a los handlers de cada sink
                foreach (IEventoRefri handler in listaSinks)
                {
                    handler.EReservasBajas(kilosAlimentos);
                }
            }
        }
    }
}
