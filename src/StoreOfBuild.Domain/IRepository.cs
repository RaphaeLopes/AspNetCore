namespace StoreOfBuild.Domain
{
    public interface IRepository<tEntity>
    {
         tEntity GetById(int id);
         void Save (tEntity entity);
    }
}