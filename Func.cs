using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class Func
    {
        static void Main()
        {
            Func<string, string, string> combinarNome = (nome, sobrenome) => $"{nome} {sobrenome}";

            Func<string, string> paraMaiusculas = s => s.ToUpper();

            Func<string, string> removerEspacos = s => s.Replace(" ", "");

            string nomeFinal = removerEspacos(paraMaiusculas(combinarNome("luis", "bucciarati")));

            Console.WriteLine(nomeFinal);
        }
    }
}
