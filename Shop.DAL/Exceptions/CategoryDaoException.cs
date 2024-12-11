
namespace Shop.DAL.Exceptions
{
    public class CategoryDaoException : Exception
    {
        public CategoryDaoException(string message) : base(message) 
        { 
            //Persistir o enviar notifación
        }
    }
}
