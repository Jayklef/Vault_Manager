using Safe.DataAccess.Dtos;
using Safe.DataAccess.Repositories.Interface;
using Safe.Domain;
using Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Concrete
{
    public class ItemRepository : IItemRepository
    {
        private readonly SafeContext _context;

        public ItemRepository(SafeContext context)
        {
            _context = context;
        }

        public List<ItemDto> GetAllItems()
        {
            var items = _context.Items.Select(i => new ItemDto
            {
                ItemId = i.ItemId,
                ItemName = i.ItemName,
                ItemDescription = i.ItemDescription,
                CurrentValue = i.CurrentValue
            }).ToList();

            return items;
        }

        public ItemDto GetItemById(int ItemId)
        {
            var item = _context.Items.Where(i => i.ItemId == ItemId).Select(i => new ItemDto
            {
                ItemId = i.ItemId,
                ItemName = i.ItemName,
                ItemDescription = i.ItemDescription,
                CurrentValue = i.CurrentValue
            }).FirstOrDefault();

            return item;
        }

        public void CreateItem(ItemDto itemDto)
        {
            var item = new Item
            {
                ItemName = itemDto.ItemName,
                ItemDescription = itemDto.ItemDescription,
                CurrentValue = itemDto.CurrentValue
            };

            _context.Add(item);
            _context.SaveChanges();
        }
        public void UpdateItem(ItemDto itemDto)
        {
            var item = _context.Items.Where(i => i.ItemId == itemDto.ItemId).FirstOrDefault();

            item.ItemName = itemDto.ItemName;
            item.ItemDescription = itemDto.ItemDescription;
            item.CurrentValue = itemDto.CurrentValue;

            _context.SaveChanges();
        }

        public void DeleteItem(int ItemId)
        {
            var item = _context.Items.Where(i => i.ItemId == ItemId).FirstOrDefault();

            _context.Items.Remove(item);
            _context.SaveChanges();
        }

    }
}
