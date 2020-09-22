using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex4Candidato.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex4Candidato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEleicaoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem dos Times à Candidatura .");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Dados do Time por id .");

        }
        [HttpPost]
        public async Task<IActionResult> Post(TimeEleicao timeEleicao)
        {
            return Ok("Candidatos castrados com sucesso !!");
        }
    }
}
