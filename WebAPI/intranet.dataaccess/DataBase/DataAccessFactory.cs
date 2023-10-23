using intranet.service;

namespace intranet.dataaccess.Factory
{
    public abstract class DataAccessFactory
    {
        public static IAlumnoDataAccess GetProductDataAccessObj()
        {
            return new AlumnoDAO();
        }

    }
}