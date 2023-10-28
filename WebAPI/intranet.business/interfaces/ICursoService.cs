using intranet.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intranet.business.interfaces
{
    public interface ICursoService
    {

        void CursoAdicionar(Curso pro);

        void CursoActualizar(Curso pro);

        void CursoEliminar(Curso pro);

        List<Curso> CursoListar();
    }
}
