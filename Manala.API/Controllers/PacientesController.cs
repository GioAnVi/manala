using Manala.Core.Entities;
using Manala.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manala.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IPacientesRepository _ipacienterepository;
        public PacientesController(IPacientesRepository ipacrep)
        {
            _ipacienterepository = ipacrep;
        }

        [HttpPost]
        public async Task<IActionResult> InsertarPaciente(Paciente insertarpac)
        {
            await _ipacienterepository.NuevoPaciente(insertarpac);
            return Ok();
        }

    }
}
