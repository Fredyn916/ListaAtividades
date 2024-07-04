using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    public class Metodos
    {
        public double EstoqueMedio { get; set; }

        public void CalcularEstoqueMedio(int QuantidadeMin, int QuantidadeMax)
        {
            EstoqueMedio = (QuantidadeMin + QuantidadeMax) / 2;
        }

        public void DolarToReal()
        {
            Console.WriteLine("Digite a atual cotação do dólar:");
            double dolar = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: (dólar)");
            double valor = int.Parse(Console.ReadLine());
            double resultado = valor * dolar;

            Console.WriteLine($"US {valor} = R$ {resultado}. DOL: {dolar}");
        }
    }
}
