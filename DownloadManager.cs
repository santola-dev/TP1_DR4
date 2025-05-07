using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DW
{
    internal class DownloadManager
    {
        public event Action DownloadCompleted;

        public void IniciarDownload()
        {
            Console.WriteLine("Iniciando download...");
            Thread.Sleep(3000);
            DownloadCompleted?.Invoke();
        }

    }

    class Download
    {
        static void Main(string[] args)
        {
            DownloadManager gerente = new DownloadManager();
            gerente.DownloadCompleted += NotificarConclusao;

            gerente.IniciarDownload();
        }

        static void NotificarConclusao()
        {
            Console.WriteLine("Download concluído com sucesso!");
        }
    }
}
