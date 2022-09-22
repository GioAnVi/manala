using Manala.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manala.Core.Interface
{
   public interface IPacientesRepository
    {
        Task<Paciente> NuevoPaciente(Paciente pac);
    }
}
