using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste04.Models
{
    public class metodos
    {
        public void CalcularPercentual(double total, double estado){
            double media = estado/total;
            System.Console.WriteLine($"O percentual foi:{(media).ToString("p2")}");

        }

    }
}