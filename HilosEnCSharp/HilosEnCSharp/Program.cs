using System;
using System.Threading;

namespace HilosEnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SumarThread sumarThread = new SumarThread();
            //creamos los hilos
            Thread hilo1 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            Thread hilo2 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            Thread hilo3 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));

            hilo1.Name = "hilo 1";
            hilo2.Name = "hilo 2";
            hilo3.Name = "hilo 3";

            Int32[] parametros1 = { 2, 1 };
            Int32[] parametros2 = { 2, 1 };
            Int32[] parametros3= { 2, 1 };
            Console.WriteLine("Preparando hilos");
            hilo1.Start(parametros1);//parametrizados
            hilo2.Start(parametros2);
            hilo3.Start(parametros3);

            Console.WriteLine("hilos procesando...");

            Console.ReadLine();
         }
    }
}
