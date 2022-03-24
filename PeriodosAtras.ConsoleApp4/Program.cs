using System;

namespace PeriodosAtras.ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           
        
           
            TimeSpan dias;
            Contador contador = new Contador();

            string datadeentrada;
            DateTime dtDatas;

            Console.WriteLine("Nossa data atual é dia 24/03/2022, coloque uma data qualquer e vamos ver  quantos dias está");


            datadeentrada = Console.ReadLine();

            dtDatas = DateTime.Parse(datadeentrada);

            Console.WriteLine("Confirma a data digitada? " + dtDatas);


            
            Console.ReadKey();
            
            dias = DateTime.Now - dtDatas;
            if (dias.Days < 7)
            {
                Console.WriteLine(dias.Days + " dias atras ");
            }
            else if (dias.Days < 30)
            {
                int semanas = dias.Days / 7;
                Console.WriteLine("foi a " + semanas + " semana atras");

            }
            else if (dias.Days < 360)
            {
                int mes = dias.Days / 30;
                Console.WriteLine("foi a" + mes + "meses e a " + semanas + "semanas");
            }




        }
        

    }
}
