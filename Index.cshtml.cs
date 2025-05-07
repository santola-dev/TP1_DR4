using Microsoft.AspNetCore.Mvc.RazorPages;
using LojaProdutos.Models;
using System.Collections.Generic;

namespace LojaProdutos.Pages
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Notebook", Preco = 3500.00m },
                new Produto { Nome = "Smartphone", Preco = 2200.00m },
                new Produto { Nome = "Fone Bluetooth", Preco = 350.00m }
            };
        }
    }
}
