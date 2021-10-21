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
                itemId = i.itemId,
                itemName = i.itemName,
                itemDescription = i.itemDescription,
                currentValue = i.currentValue
            }).ToList();

            return items;
        }

        public ItemDto GetItemById(int itemId)
        {
            var item = _context.Items.Where(i => i.itemId == itemId).Select(i => new ItemDto
            {
                itemId = i.itemId,
                itemName = i.itemName,
                itemDescription = i.itemDescription,
                currentValue = i.currentValue
            }).FirstOrDefault();

            return item;
        }

        public void CreateItem(ItemDto itemDto)
        {
            var item = new Item
            {
                itemName = itemDto.itemName,
                itemDescription = itemDto.itemDescription,
                currentValue = itemDto.currentValue
            };

            _context.Add(item);
            _context.SaveChanges();
        }
        public void UpdateItem(ItemDto itemDto)
        {
            var item = _context.Items.Where(i => i.itemId == itemDto.itemId).FirstOrDefault();

            item.itemName = itemDto.itemName;
            item.itemDescription = itemDto.itemDescription;
            item.currentValue = itemDto.currentValue;

            _context.SaveChanges();
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Where(i => i.itemId == itemId).FirstOrDefault();

            _context.Items.Remove(item);
            _context.SaveChanges();
        }

    }
}
