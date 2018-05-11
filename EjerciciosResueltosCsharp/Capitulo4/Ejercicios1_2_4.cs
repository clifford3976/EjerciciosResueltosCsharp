using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosResueltosCsharp.Capitulo4
{
    class Ejercicios1_2_4
    {
        public void cap4_1()
        {
            int N;
            string linea;

            Console.WriteLine("ingrese un numero");
            linea = Console.ReadLine();
            N = int.Parse(linea);

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "x" + N + "=" + i * N + "\n");
            }
            Console.ReadKey();
        }

        public void cap4_2()
        {
           try
            {
                Console.Write("digite un numero: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("digite a que potencia se va a elevar: ");
                int pot = Convert.ToInt32(Console.ReadLine());

                int res = n;

                for(int i =1; i < pot; i++)
                {
                    res = (res * n);
                }

                Console.Write("el resultado es: " + res);
            }
            catch(Exception)
            {
                Console.Write("digite solo numeros enteros");
            }

            Console.ReadLine();
            Console.ReadKey();


        }

        public void cap4_4()
        {
            int cont = 0; ;

            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont += 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine(i);
                }
                cont = 0;
            }
            Console.ReadKey();
        }

    }
}
