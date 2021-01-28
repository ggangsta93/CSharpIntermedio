using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    class Program
    {
        //Tutorial C# nivel intermedio 2 --- Interfaces
        static void Main(string[] args)
        {
            int opcion = 0;
            double vala = 0.0;
            double valb = 0.0;

            string valor = "";

            IOperacion operacion = new CSuma();
            while (opcion != 5)
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicación, 4-División");
                Console.WriteLine("¿Qué opción deseas?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de a");
                valor = Console.ReadLine();
                vala = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor de b");
                valor = Console.ReadLine();
                valb = Convert.ToDouble(valor);

                if (opcion == 1)
                    operacion = new CSuma(); 
                if (opcion == 2)
                    operacion = new CResta();
                if (opcion == 3)
                    operacion = new CMulti();
                if (opcion == 4)
                    operacion = new CDiv();

                //Aquí nuestro programa trabaja en terminos
                //del concepto Operacion, en lugar de en
                //terminos de cosas concretas como suma, resta, multiplicacion o division

                operacion.calcular(vala, valb);
                operacion.mostrar();
            }
           
            
        }
    }
}
