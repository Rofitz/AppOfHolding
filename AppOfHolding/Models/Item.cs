using AppOfHolding.Models;

namespace AppOfHolding
{
    public class Item : IModel
    {
        public virtual string Name { get; set; }

        public ItemTypeEnum Type { get; set; }
    }
}