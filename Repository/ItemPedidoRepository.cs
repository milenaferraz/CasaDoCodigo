using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repository
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
       
    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext context) : base(context)
        {

        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            return dbSet
                  .Where(i => i.Id == itemPedidoId)
                  .SingleOrDefault();
        }
    }
}
