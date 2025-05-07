using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class TemperatureSensor
    {
        public event Action<double> TemperatureExceeded;

        public void LerTemperatura(double temperatura)
        {
            if (temperatura > 100)
            {
                TemperatureExceeded?.Invoke(temperatura);
            }
        }
    }

    class Termometro
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += MostrarAlerta;

            while (true)
            {
                Console.WriteLine("Digite uma temperatura (ou 'sair' para encerrar): ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                    break;

                if (double.TryParse(entrada, out double temperatura))
                {
                    sensor.LerTemperatura(temperatura);
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
        }

        static void MostrarAlerta(double temperatura)
        {
            Console.WriteLine($"Alerta: Temperatura excedida! Valor registrado: {temperatura}°C");
        }
    }
}
