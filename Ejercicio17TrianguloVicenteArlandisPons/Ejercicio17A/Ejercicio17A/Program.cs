using System;

namespace Ejercicio17A
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            int d= 1;
            float a = 1;
            float b = 1;
            int c = 1;
            float segmento = 1;
            float radicando = 1;
            double area = 1;
            double areaRound = 1;
           
            Console.WriteLine("Intoduce las medidas de los tres lados de un triángulo, te diremos si se trata de un triangulo equilatero\ny calcularemos su área. (Las medidas se tratarán en centimetros)");
           //Para permitir que el ususaro repita las operaciones las veces que desee
            while (d == 0)
            {
                
                int e = 0;
                
                //para el calculo de la posibilidad del triangulo 
                //(la suma del primer lado menor y segundo lado menor debe ser mayor que lo que mide el lado mayor)
                while (e == 0)
                {
                    int f = 0;
                    int g = 0;
                    int h = 0;
                    float auxMenor1 = 0;
                    float auxMenor2 = 0;
                    float auxMayor = 0;
                    float suma = 0;
                   
                    //para que se acote la posibilidad de que solo se introducan números positivos
                    while (f == 0)
                    {
                       
                        try
                        {
                            Console.WriteLine("introduce el primer lado:");
                            a = float.Parse(Console.ReadLine());
                            if (a > 0)
                            {
                                f = 1;
                            }
                            else
                            {
                                Console.WriteLine("El numero debe ser positivo.");
                            }
                        }
                        catch (Exception e1)
                       {
                            Console.WriteLine("Solo se permiten números.");
                        }
                    }
                    //
                    while (g == 0)
                    {
                        try
                        {
                            Console.WriteLine("introduce el segundo lado:");
                            b = float.Parse(Console.ReadLine());
                            if (b > 0)
                            {
                                g = 1;
                            }
                            else
                            {
                                Console.WriteLine("El numero debe ser positivo.");
                            }
                        }
                        catch (Exception e1)
                        {
                            Console.WriteLine("Solo se permiten números.");
                        }
                    }
                    while (h == 0)
                    {
                        try
                        {
                            Console.WriteLine("introduce el tercer lado:");
                            c = float.Parse(Console.ReadLine());
                        
                        if (c > 0)
                            {
                                h = 1;
                            }
                            else
                            {
                                Console.WriteLine("El numero debe ser positivo.");
                            }
                        }
                        catch (Exception e1)
                        {
                            Console.WriteLine("Solo se permiten números.");
                        }
                    }
                    if (a >= b)
                    {
                        auxMenor1 = b;
                        if (a >= c)
                        {
                            auxMenor2 = c;
                            auxMayor = a;
                            suma=auxMenor1 + auxMenor2;
                            if (suma >auxMayor)
                            {
                                if (a == b & b == c)
                                {
                                    Console.WriteLine("El triangulo ES EQUILÁTERO porqué tiene todos sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("El triangulo NO es EQUILÁTERO porqué NO tiene sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                segmento = (a + b + c) / 2;
                                radicando = (segmento * (segmento - a) * (segmento - b) * (segmento - c));
                                area = Math.Sqrt(radicando);
                                areaRound = Math.Round(area, 3);
                                Console.WriteLine("El área del triangulo es " + areaRound + " cm2.\nPulsa una tecla para continuar");
                                Console.ReadKey();
                                e = 1;
                            }
                            else
                            {
                                Console.WriteLine("Con estos medidas no se puede formar un triángulo.\nLa suma de los lados menores es menor o igual que el lado mayor.\nPor favor, introduzca los datos de nuevo.");
                                e = 0;
                               
                            }
                        }
                        else
                        {
                            auxMenor2 = a;
                            auxMayor = c;
                            suma = auxMenor1 + auxMenor2;
                            if (suma > auxMayor)
                            {
                                if (a == b & b == c)
                                {
                                    Console.WriteLine("El triangulo ES EQUILÁTERO porqué tiene todos sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("El triangulo NO es EQUILÁTERO porqué NO tiene sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                segmento = (a + b + c) / 2;
                                radicando = (segmento * (segmento - a) * (segmento - b) * (segmento - c));
                                area = Math.Sqrt(radicando);
                                areaRound = Math.Round(area, 3);
                                Console.WriteLine("El área del triangulo es " + areaRound + " cm2.\nPulsa una tecla para continuar");
                                Console.ReadKey();
                                e = 1;
                            }
                            else
                            {
                                Console.WriteLine("Con estas medidas no se puede formar un triángulo.\nLa suma de los lados menores es menor o igual que el lado mayor.\nPor favor, introduzca los datos de nuevo.");
                                e = 0;
                                
                            }
                        }
                               
                    }
                    else if(a<=b)
                    {
                        auxMenor1 = a;
                        if (b <= c)
                        {
                            auxMenor2 = b;
                            auxMayor = c;
                            suma = auxMenor1 + auxMenor2;
                            if (suma > auxMayor)
                            {
                                if (a == b & b == c)
                                {
                                    Console.WriteLine("El triangulo ES EQUILÁTERO porqué tiene todos sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("El triangulo NO es EQUILÁTERO porqué NO tiene sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                segmento = (a + b + c) / 2;
                                radicando = (segmento * (segmento - a) * (segmento - b) * (segmento - c));
                                area = Math.Sqrt(radicando);
                                areaRound = Math.Round(area, 3);
                                Console.WriteLine("El área del triangulo es " + areaRound + " cm2.\nPulsa una tecla para continuar");
                                Console.ReadKey();
                                e = 1;
                            }
                            else
                            {
                                Console.WriteLine("Con estas medidas no se puede formar un triángulo.\nLa suma de los lados menores es menor o igual que el lado mayor.\nPor favor, introduzca los datos de nuevo.");
                                e = 0;
                                                         
                            }
                        }
                        else
                        {
                            auxMenor2 = c;
                            auxMayor = b;
                            suma = auxMenor1 + auxMenor2;
                            if (suma > auxMayor)
                            {
                                if (a == b & b == c)
                                {
                                    Console.WriteLine("El triangulo ES EQUILÁTERO porqué tiene todos sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("El triangulo NO es EQUILÁTERO porqué NO tiene sus LADOS IGUALES");
                                    Console.WriteLine("Pulse una tecla para calcular su área");
                                    Console.ReadKey();
                                }
                                segmento = (a + b + c) / 2;
                                radicando = (segmento * (segmento - a) * (segmento - b) * (segmento - c));
                                area = Math.Sqrt(radicando);
                                areaRound = Math.Round(area, 3);
                                Console.WriteLine("El área del triangulo es " + areaRound + " cm2.\nPulsa una tecla para continuar");
                                Console.ReadKey();
                                e = 1;
                            }
                            else
                            {
                                Console.WriteLine("Con estas medidas no se puede formar un triángulo.\nLa suma de los lados menores es menor o igual que el lado mayor.\nPor favor, introduzca los datos de nuevo.");
                                e = 0;
                               
                            }
                        }
                    }

                }
                
                Console.WriteLine("Pulsa 1 para e INTRO para volver a empezar o cualquier otra tecla para salir ");
                try
                {
                    int bucle = int.Parse(Console.ReadLine());
                    if (bucle == 1)
                    {

                    }
                    else
                    {
                        d = 1;
                    }
                }catch(Exception e1)
                {
                    d = 1;
                }
                
                }
            Console.WriteLine("HASTA LA PRÓXIMA¡");
            Console.ReadKey();
        }
        }
    }

