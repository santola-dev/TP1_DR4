using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class Descontos
    {
        delegate decimal CalculateDiscount(decimal originalPrice);

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preço original do produto: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal precoOriginal))
            {
                CalculateDiscount desconto = AplicarDesconto;

                decimal precoComDesconto = desconto(precoOriginal);

                Console.WriteLine($"\nPreço original: R$ {precoOriginal}");
                Console.WriteLine($"Preço com 10% de desconto: R$ {precoComDesconto:F2}");

            }
            else
            {
                Console.WriteLine("Valor inválido. Digite um número decimal.");
            }
        }

        static decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.9m;
        }
    }
}
