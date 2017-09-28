namespace AppOfHolding.core.Models
{
    using System.Collections.Generic;

    public class Character
    {
        public string CharacterName { get; set; }

        public Gold Gold { get; set; }

        public IEnumerable<Item> Inventory { get; set; }
    }
}