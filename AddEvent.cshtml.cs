using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCatalog.Models;
using System;

namespace LojaProdutos
{
    public class AddEventModel : PageModel
    {
        [BindProperty]
        public Event NovoEvento { get; set; }

        public bool ExibirMensagem { get; set; }

        public static Action<Event> OnEventCreated = e =>
        {
            Console.WriteLine($"Evento criado: {e.Titulo}, {e.Data.ToShortDateString()}, {e.Local}");
        };

        public void OnGet()
        {
            ExibirMensagem = false;
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                ExibirMensagem = false;
                return;
            }
            OnEventCreated?.Invoke(NovoEvento);
            ExibirMensagem = true;
        }
    }
}
