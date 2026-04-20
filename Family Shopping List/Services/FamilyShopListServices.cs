using Family_Shopping_List.Items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppItem = Family_Shopping_List.Data.DbContextFamilyShopList;

namespace Family_Shopping_List.Services
{
    public  class FamilyShopListServices
    {
        protected readonly AppItem App;
        public FamilyShopListServices(AppItem App2)
        {
            App = App2;
        }

        public async Task AddItem(Item item)
        {
            App.FamilyShopList.AddAsync(item);
            await App.SaveChangesAsync();
        }


        public  Task<List<Item>> GetShoppingList()
        {
            return  App.FamilyShopList.AsNoTracking().Where(x => x.State == false).ToListAsync();
        }
        public  Task<List<Item>> GetItemsPurchased()
        {
            return  App.FamilyShopList.AsNoTracking().Where(x => x.State == true).ToListAsync();
        }

        public Task<List<Item>> GetAllItems()
        {
            return  App.FamilyShopList.AsNoTracking().ToListAsync();
        }

        public async Task<Item> FindItem(int idItem)
        {
            return await App.FamilyShopList.FirstOrDefaultAsync(i => i.Id == idItem);
        }

        public async Task UpdateItem(Item item)
        {
            App.Update(item);
            await App.SaveChangesAsync();
        }
    }
}
