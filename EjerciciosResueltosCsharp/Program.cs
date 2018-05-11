using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosResueltosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            for (; ; )
            {
                Console.WriteLine("Aqui tenemos todos los ejercicios del capitulo 1 hastas el capitulo 4");
                Console.WriteLine("Escoge una opcion: ");
                Console.WriteLine("1- Capitulo 1 ");
                Console.WriteLine("2- Capitulo 2 ");
                Console.WriteLine("3- Capitulo 3 ");
                Console.WriteLine("4- Capitulo 4 ");
                linea = Console.ReadLine();
                Console.Clear();
                switch (linea)
                {
                    case "1":
                        Console.WriteLine("1- nombre en pantalla de consola");
                        Console.WriteLine("2- mas texto en pantalla de consola");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            EjerciciosResueltosCsharp.Capitulo1.Ejercicios1_5 E = new EjerciciosResueltosCsharp.Capitulo1.Ejercicios1_5();
                            E.cap1_1();

                        }
                        else
                            if (linea == "2")
                        {
                            EjerciciosResueltosCsharp.Capitulo1.Ejercicios1_5 E = new EjerciciosResueltosCsharp.Capitulo1.Ejercicios1_5();
                            E.cap1_5();
                        }
                        Console.Clear();

                        break;

                    case "2":
                        Console.WriteLine("1- perimetro poligono regular");
                        Console.WriteLine("2- conversion de grados radianes");
                        Console.WriteLine("3- conversion de celcio a fahreinhgt");
                        Console.WriteLine("4- cambio de dolar y euro");

                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5 E = new EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5();
                            E.cap2_1();

                        }
                        else
                            if (linea == "2")
                        {
                            EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5 E = new EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5();
                            E.cap2_3();
                        }
                        else
                            if (linea == "3")
                        {
                            EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5 E = new EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5();
                            E.cap2_4();
                        }
                        else
                            if (linea == "4")
                        {
                            EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5 E = new EjerciciosResueltosCsharp.Capitulo2.Ejercicios1_3_4_5();
                            E.cap2_5();
                        }
                        Console.Clear();

                        break;

                    case "3":
                        Console.WriteLine("1- numero par e impar");
                        Console.WriteLine("2- los dias de la semana");
                        Console.WriteLine("3- area y perimetro de poligono regular");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            EjerciciosResueltosCsharp.Capitulo3.Ejercicios1_4_5 E = new EjerciciosResueltosCsharp.Capitulo3.Ejercicios1_4_5();
                            E.cap3_1();

                        }
                        else
                            if (linea == "2")
                        {
                            EjerciciosResueltosCsharp.Capitulo3.Ejercicios1_4_5 E = new EjerciciosResueltosCsharp.Capitulo3.Ejercicios1_4_5();
                            E.cap3_4();
                        }
                        else
                            if (linea == "3")
                        {
                            EjerciciosResueltosCsharp.Capitulo3.Ejercicios1_4_5 E = new EjerciciosResueltosCsharp.Capitulo3.Ejercicios1_4_5();
                            E.cap3_5();
                        }
                        Console.Clear();

                        break;

                    case "4":
                        Console.WriteLine("1- tabla de multiplicacion");
                        Console.WriteLine("2- potencia de un numero");
                        Console.WriteLine("3- numeros primos");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            EjerciciosResueltosCsharp.Capitulo4.Ejercicios1_2_4 E = new EjerciciosResueltosCsharp.Capitulo4.Ejercicios1_2_4();
                            E.cap4_1();

                        }
                        else
                            if (linea == "2")
                        {
                            EjerciciosResueltosCsharp.Capitulo4.Ejercicios1_2_4 E = new EjerciciosResueltosCsharp.Capitulo4.Ejercicios1_2_4();
                            E.cap4_2();
                        }
                        else
                           if (linea == "3")
                        {
                            EjerciciosResueltosCsharp.Capitulo4.Ejercicios1_2_4 E = new EjerciciosResueltosCsharp.Capitulo4.Ejercicios1_2_4();
                            E.cap4_4();
                        }
                        Console.Clear();

                        break;

                    default:
                        Console.WriteLine("lamentablemente esa opción no es valida\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
    