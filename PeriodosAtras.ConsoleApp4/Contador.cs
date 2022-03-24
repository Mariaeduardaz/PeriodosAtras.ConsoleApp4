using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp4
{
    internal class Contador
    {

        public void DataCalculos()
        {
            DateTime DataAtual = DateTime.Now;
            string Data1dia = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            Console.WriteLine(" Há um dia atras");
            DateTime.Now.AddDays(-1);
        }
        public void DataCalculos2()
        {
            string Data2d = DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy");
            Console.WriteLine("Há dois dias atras");
        }
        public void DataCalculos3()
        {
            string Data3d = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            Console.WriteLine("Há uma semana atras");
        }
        public void DataCalculos4()
        {
            string Data2m = DateTime.Now.AddMonths(-2).ToString("dd/MM/yyyy");
            Console.WriteLine("Há dois meses atras");
        }

            string Data10a = DateTime.Now.AddYears(10).ToString("dd/MM/yyyy");
        

        


    }
}
