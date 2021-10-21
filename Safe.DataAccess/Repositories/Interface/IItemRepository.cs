using Safe.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Interface
{
    public interface IItemRepository
    {
        List<ItemDto> GetAllItems();
        ItemDto GetItemById(int Id);
        void CreateItem(ItemDto itemDto);
        void UpdateItem(ItemDto itemDto);
        void DeleteItem(int Id);
    }
}
