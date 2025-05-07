using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class BoasVindas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um idioma (portugues, ingles, espanhol):");
            string idioma = Console.ReadLine()?.ToLower();

            Dictionary<string, Action<string>> mensagens = new Dictionary<string, Action<string>>
            {
                { "portugues", nome => Console.WriteLine($"Bem-vindo, {nome}!") },
                { "ingles", nome => Console.WriteLine($"Welcome, {nome}!") },
                { "espanhol", nome => Console.WriteLine($"¡Bienvenido, {nome}!") }
            };

            if (mensagens.ContainsKey(idioma))
            {
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                mensagens[idioma](nome);
            }
            else
            {
                Console.WriteLine("Idioma não suportado.");
            }
        }

    }
}
