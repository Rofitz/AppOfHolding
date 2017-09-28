namespace AppOfHolding.core.Services
{
    using Models;
    using System.Collections.Generic;

    interface IApiService<IModel>
    {
        IEnumerable<Item> Get();

        IModel Get(int id);

        void Post(IModel model);

        int Put(IModel id);

        void Delete(int id);
    }
}