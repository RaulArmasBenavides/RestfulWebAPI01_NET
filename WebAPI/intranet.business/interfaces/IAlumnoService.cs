using intranet.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intranet.business.interfaces
{
    public interface IAlumnoService
    {

        void AlumnoAdicionar(Alumno pro);

        void AlumnoActualizar(Alumno pro);

        void AlumnoEliminar(Alumno pro);

        bool AlumnoEliminar2(int id);
    }
}
