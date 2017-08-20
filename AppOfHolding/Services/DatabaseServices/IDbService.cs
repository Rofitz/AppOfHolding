namespace AppOfHolding.Services.DatabaseServices
{
    interface IDbService<IModel>
    {
        IModel Get();

        IModel Get(int id);

        void Add(IModel model);

        int Edit(IModel id);

        void Delete(int id);
    }
}