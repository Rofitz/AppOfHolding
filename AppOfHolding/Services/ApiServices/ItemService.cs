using AppOfHolding.Models;
using System.Collections.Generic;

namespace AppOfHolding.Services.DatabaseServices
{
    public class ItemDbService : BaseDbService<Item>
    {
        public IEnumerable<Item> TempGet()
        {
            return new List<Item>
            {
                new Item
                {
                    Name = "sword",
                    Type = ItemTypeEnum.WEAPON
                },
                new Item
                {
                    Name = "axe",
                    Type = ItemTypeEnum.WEAPON
                },
                new Item
                {
                    Name = "Leather Boots of Haste",
                    Type = ItemTypeEnum.ARMOR
                },
                new Currency
                {
                    Name = "Money",
                    Type = ItemTypeEnum.CURRENCY,
                    Gold = 1000,
                    Platinum = 100,
                    Electrum = 1,
                    Silver = 10,
                    Copper = 50                    
                }
            };
        }
    }
}