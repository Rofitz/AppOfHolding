namespace AppOfHolding.core.Services
{
    using Models;
    using System.Collections.Generic;

    public class ItemDbService : IApiService<Item>
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Item Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Post(Item model)
        {
            throw new System.NotImplementedException();
        }

        public int Put(Item id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Item> Get()
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
                new Gold
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