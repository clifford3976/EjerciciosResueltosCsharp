using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosResueltosCsharp.Capitulo2
{
    class Ejercicios1_3_4_5
    {
        public void cap2_1()
        {
            float lado;
            int cantlado;

            Console.WriteLine("digite el valor del lado del poligono regular");
            lado = float.Parse(Console.ReadLine());

            Console.WriteLine("digite la cantidad de lados");
            cantlado = int.Parse(Console.ReadLine());

            Console.Write("el perimetro es : " + lado * cantlado);

            Console.ReadKey();
        }

        public void cap2_3()
        {

            double grados;
            double D = 0.0174533;

            Console.WriteLine("digite la cantidad grados");
            grados = double.Parse(Console.ReadLine());

            Console.WriteLine("el resultado en Radianes es : " + grados * D);

            Console.ReadKey();
        }

        public void cap2_4()
        {
            float celcio;
            float r;


            Console.WriteLine("digite el valor de celcio");
            celcio = float.Parse(Console.ReadLine());

            if (celcio == 0)
            {
                r = 32;
            }
            else
            {
                r = ((9 * celcio) / 5) + 32;
            }
            Console.Write("el resultado en Fahrenheit : " + r);

            Console.ReadKey();

        }

        public void cap2_5()
        {
            float tasa;
            float cantE;

            Console.WriteLine("digite la cantidad de euro a cambiar");
            cantE = float.Parse(Console.ReadLine());

            Console.WriteLine("digite la tasa de cambio");
            tasa = float.Parse(Console.ReadLine());

            Console.Write("el resultado en dolr es : " + tasa * cantE);

            Console.ReadKey();
        }
    }
}
