using CasaDoCodigo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class UpdateQuantidadeResponseModels
    {
       
        public ItemPedido ItemPedido { get; }

        public CarrinhoViewModels CarrinhoViewModels { get; }

        public UpdateQuantidadeResponseModels(ItemPedido itemPedido, CarrinhoViewModels carrinhoViewModels)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModels = carrinhoViewModels;
        }
    }
}
