using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    class Program
    {
        //Definimos el delegado con las caracteristicas que nos interesa
        public delegate void MiDelegado(string m);
        static void Main(string[] args)
        {
            //Creamos un objeto del delegado y lo refeernciamos a un metodo
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            //Ahora por medio del delegado hacemos uso del metodo
            delegado("Hola a todos");

            //Hacemos que apunte a otro metodo
            delegado = new MiDelegado(CPastel.mostrarPastel);

            //Ahora invocamos el otro metodo
            delegado("Feliz cumpleaños");
        }
    }
}
