﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TypeTriangle // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double E = 0.1, A, B, C;

            // Ввод данных
            Console.WriteLine("Введите A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C:");
            C = Convert.ToDouble(Console.ReadLine());

            if (A > 0 && B > 0 && C > 0)
            {
                if (A + B > C)
                {
                    if (A == B && A == C && C == B)
                    {
                        Console.WriteLine("Равносторонний");
                    }
                    else
                    {
                        if (A == B)
                        {
                            Console.WriteLine("Равнобедренный");
                        }
                        else
                        {
                            if ((A * A + B * B) - C * C < E)
                            {
                                Console.WriteLine("Прямоугольный");
                            }
                            else
                            {
                                Console.WriteLine("Общего вида");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Треугольника с такими сторонами не существует");
                }
            }
            else
            {
                Console.WriteLine("Треугольник не может иметь отрицательных сторон (");
            }

        }
    }
}