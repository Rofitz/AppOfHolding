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
                    Name = "sword"
                },
                new Item
                {
                    Name = "axe"
                },
                new Item
                {
                    Name = "bow"
                }
            };
        }
    }
}