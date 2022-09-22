using Manala.Core.Entities;
using Manala.Core.Interface;
using Manala.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manala.Infraestructure.Repositories
{
    public class PacienteRepository : IPacientesRepository
    {
        private readonly DataContext _datacontext;
        public PacienteRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }
        public async Task<Paciente> NuevoPaciente(Paciente pac)
        {
            try
            {
                await _datacontext.AddAsync(pac);
                await _datacontext.SaveChangesAsync();
                return pac;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
