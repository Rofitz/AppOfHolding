using AppOfHolding.Models;
using AppOfHolding.Services.DatabaseServices;

namespace AppOfHolding.Services
{
    public class BaseDbService<T> : IDbService<T> where T : IModel
    {
        public void Post(T model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Put(T id)
        {
            throw new System.NotImplementedException();
        }

        public T Get()
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}