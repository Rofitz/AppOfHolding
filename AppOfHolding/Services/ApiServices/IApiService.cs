namespace AppOfHolding.Services.DatabaseServices
{
    interface IDbService<IModel>
    {
        IModel Get();

        IModel Get(int id);

        void Post(IModel model);

        int Put(IModel id);

        void Delete(int id);
    }
}