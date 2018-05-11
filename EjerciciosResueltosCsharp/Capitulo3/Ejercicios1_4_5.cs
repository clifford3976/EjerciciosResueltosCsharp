using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosResueltosCsharp.Capitulo3
{
    class Ejercicios1_4_5
    {
        public void cap3_1()
        {
            int N;

            Console.WriteLine("digite un numero");
            N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.Write("Este numero: " + N + " Es par");
            }
            else
            {
                Console.Write("Este numero: " + N + " No es par");
            }

            Console.ReadKey();
        }

        public void cap3_4()
        {
            string[] Dia = { "domingo", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado" };
            Console.WriteLine("digite un numero: ");
            int d = Convert.ToInt16(Console.ReadLine());
            if(d >= 1 && d <= 7)
            {
                Console.WriteLine("el dia " + d + " es " + Dia[d - 1]);
            }
            else
            {
                Console.WriteLine("no es un dia de la semana");

            }
            Console.ReadLine();
            Console.ReadKey();
        }

        public void cap3_5()
        {
            float resultado = 0.0f;
            string valor = " ";
            float lado;
            int opcion = 0;
            int cantlado;
            float a;



            Console.WriteLine("1- calcular perimetro");
            Console.WriteLine("2- calcular area");
            Console.Write("Que operación deseas hacer: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);


            Console.Write("Digite el valor del lado del poligono regular :");
            valor = Console.ReadLine();
            lado = Convert.ToSingle(valor);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("digite la cantidad de lado del poligono regular :");
                    cantlado = int.Parse(Console.ReadLine());

                    resultado = lado * cantlado;
                    break;

                case 2:
                    Console.WriteLine("digite el apotema del poligono :");
                    a = float.Parse(Console.ReadLine());

                    resultado = (lado * a) / 2;
                    break;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
            Console.Write(+resultado + " es el resultado");

            Console.ReadKey();
        }
    }
}
