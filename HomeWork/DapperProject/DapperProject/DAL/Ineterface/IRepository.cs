namespace Otus.HomerWork.DapperProject.DAL.Ineterface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity? Get(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity>? Like(string key, string value);

        void Add(TEntity entity) => throw new NotImplementedException();

        void Update(TEntity entity) => throw new NotImplementedException();

        void Delete(TEntity entity) => throw new NotImplementedException();
    }
}
