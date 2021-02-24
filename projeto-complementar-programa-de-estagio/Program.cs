using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio
{
    public class Program
    {
        static void Main(string[] args)
        {

            DateTime data1 = new DateTime(2021, 02, 23, 8, 20, 0);
            DateTime data2 = new DateTime(2021, 02, 23, 8, 35, 0);
            DateTime data3 = new DateTime();

            TimeSpan tempo = data2 - data1;
            float horas = tempo.Hours;
            Console.WriteLine(tempo.TotalHours);
            double teste = 1.1;
            Console.WriteLine(Math.Ceiling(teste));
            Console.ReadLine();
        }
    }
}
