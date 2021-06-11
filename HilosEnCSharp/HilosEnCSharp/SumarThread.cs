using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HilosEnCSharp
{
    class SumarThread
    {
        public void sumar(object parametros)
        {


            Thread current = Thread.CurrentThread;
            Int32[] numeros=(Int32[])parametros;
            Int32 resultado = numeros[0] + numeros[1];
            Console.WriteLine("Durmiendo por " + resultado + "segundos");
            Thread.Sleep(resultado * 1000);
            Console.WriteLine("El resultado de la suma es " + numeros[0] + "+"
                + numeros[1]+"="+ resultado);
            Console.WriteLine("hilo " + current.Name + " finalizo su tarea");
            
            
        }
    }
}
