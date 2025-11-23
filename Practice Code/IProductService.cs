namespace MGMApi.Services
{
    public interface IProductService
    {
        List<Models.Product> GetAll();
        Models.Product GetById(int id);
        void Add(Models.Product product);
        void Update(Models.Product product);
        void DeleteById(int id);

    }
}
