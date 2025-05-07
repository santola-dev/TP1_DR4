using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do retângulo:");
            if (!double.TryParse(Console.ReadLine(), out double baseRetangulo))
            {
                Console.WriteLine("Valor inválido para a base.");
                return;
            }

            Console.WriteLine("Digite a altura do retângulo:");
            if (!double.TryParse(Console.ReadLine(), out double alturaRetangulo))
            {
                Console.WriteLine("Valor inválido para a altura.");
                return;
            }

            Func<double, double, double> calcularArea = (baseR, altura) => baseR * altura;

            double area = calcularArea(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"\nA área do retângulo é: {area:F2}");
        }
    }
}
