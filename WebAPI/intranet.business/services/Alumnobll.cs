using intranet.entity;
using intranet.infrastructure.Factory;
using intranet.infrastructure.Repository.IRepository;
using System.Collections.Generic;

namespace intranet.business
{
    public class AlumnoBll
    {
        private readonly IAlumnoRepository _AluDataAccess;
        public AlumnoBll()
        {
            _AluDataAccess = DataAccessFactory.GetProductDataAccessObj();
        }

        public void AlumnoAdicionar(Alumno pro)
        {
            _AluDataAccess.Create(pro);
        }

        public void AlumnoActualizar(Alumno pro)
        {
            _AluDataAccess.Update(pro);
        }

        public void AlumnoEliminar(Alumno pro)
        {
            _AluDataAccess.Delete(pro.IdAlumno);
        }
        public bool AlumnoEliminar2(int id)
        {
            bool result = false;
            try
            {
                _AluDataAccess.Delete(id);
                result = true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<Alumno> AlumnoListar(int skip , int limit)
        {
            return _AluDataAccess.ReadAll(skip ,limit);
        }

        public Alumno AlumnoBuscar(int id)
        {
            return _AluDataAccess.FindById(id);
        }

    }
}