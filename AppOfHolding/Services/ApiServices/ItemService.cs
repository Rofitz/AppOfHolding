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
                    Type = "Weapon"
                },
                new Item
                {
                    Name = "axe",
                    Type = "Weapon"
                },
                new Item
                {
                    Name = "Leather Boots of Haste",
                    Type = "Armor"
                }
            };
        }
    }
}