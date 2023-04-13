using UnitOfWork.DataBase.Interface;

namespace UnitOfWork.DataBase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Método para não gravar informações no banco
        }
    }
}
