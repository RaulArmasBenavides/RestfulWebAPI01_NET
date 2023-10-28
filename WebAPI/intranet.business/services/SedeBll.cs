using System.Collections.Generic;
using System.Data.SqlClient;
using intranet.business.interfaces;
using intranet.entity;
using intranet.infrastructure.Repository;
using intranet.infrastructure.Repository.IRepository;

namespace intranet.business
{
    public class SedeBll : ISedeService
    {
        ISedeRepository dao;
        public SedeBll()
        {
            dao = new SedeRepository();
        }

        public void SedeAdicionar(Sede pro)
        {
            try
            {
                dao.Create(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void SedeActualizar(Sede pro)
        {
            try
            {
                dao.Update(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void SedeEliminar(Sede pro)
        {
            try
            {
                dao.Delete(pro.idsede);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public Sede SedeBuscar(Sede pro)
        {
            try
            {
                return dao.Find(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Sede> SedesListar()
        {
            try
            {
                return dao.ReadAll();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}