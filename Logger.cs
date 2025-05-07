using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class Logger
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string> logDelegate = null;
            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            Console.WriteLine("Digite uma mensagem para log:");
            string mensagem = Console.ReadLine();

            logDelegate?.Invoke(mensagem);

            Console.WriteLine("\nLogs registrados.");
        }



        public void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        public void LogToFile(string message)
        {
            File.AppendAllText("log.txt", $"[File] {message}{Environment.NewLine}");
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine($"[Database] Simulando gravação no banco de dados: {message}");
        }
    }
}
