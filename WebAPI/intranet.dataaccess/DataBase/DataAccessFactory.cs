using intranet.infrastructure.Repository;
using intranet.infrastructure.Repository.IRepository;
namespace intranet.infrastructure.Factory
{
    public abstract class DataAccessFactory
    {
        public static IAlumnoRepository GetProductDataAccessObj()
        {
            return new AlumnoRepository();
        }

    }
}