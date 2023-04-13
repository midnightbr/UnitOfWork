namespace UnitOfWork.DataBase.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
