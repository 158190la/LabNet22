﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lecturaescritura.Menu();
            int opcion = int.Parse(Console.ReadLine());           
            while (opcion != 5)
            {
                switch (opcion)
                {
                    //ejercicio 1
                    case 1:                        
                            var divisor1 = Lecturaescritura.IngresoDivisor();                       
                            try
                            {
                                Console.WriteLine(Div0.Dividir(divisor1.Item1,divisor1.Item2));
                            }
                       
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                            finally
                            {
                                Console.WriteLine("operacion finalizada");
                            }

                        break;
                    //ejercicio 2
                    case 2:
                            var divisor2 = Tuple.Create(1,1);
                            try
                            {
                                divisor2 = Lecturaescritura.IngresoDivisor();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada");
                            }                       

                            try
                            {
                                Console.WriteLine(Div0.Dividir(divisor2.Item1, divisor2.Item2));
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Solo Chuck Norris divide por 0");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                            finally
                            {
                                Console.WriteLine("operacion finalizada");
                            }
                        break;
                    //ejercicio 3
                    case 3: 
                        {
                            try
                            {                                
                                Console.WriteLine(Div0.Dividir(0,1));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.ToString());
                                Console.WriteLine(e.GetType().ToString());
                            }                            
                        }
                        break;
                     //ejercicio 4
                     case 4:
                        {
                            
                            try
                            {
                                Excepcionpersonalizada.ExcepcionpersonalizadaValidacion(0, 1);
                                Console.WriteLine(Div0.Dividir(0,1));
                            }
                            catch (Excepcionpersonalizada ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        break;
                }
                Lecturaescritura.Menu();
                opcion = int.Parse(Console.ReadLine());

            }

        
        }

    }
}
