using System.Collections.Generic;
using CatalogService.Models;

namespace CatalogService.Interfaces
{
    public interface IGoodsSender
    { 

        void SendGoods(IEnumerable<GoodsItem> items);
    }
}
