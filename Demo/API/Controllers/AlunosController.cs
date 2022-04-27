using System;
using System.Net.Mime;
using API.DTOs.Alunos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/v1/alunos/")]
    public class AlunosController : ControllerBase
    {
         /// <summary>
        /// Retorna lista de todos os alunos
        /// </summary>
        /// <returns>Lista de RetornoAluno</returns>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ListaAlunos> GetAlunos()
        {
            return Ok();
        }

        /// <summary>
        /// Retorna o aluno pelo id buscado
        /// </summary>
        /// <param name="alunoId">Aluno id</param>
        /// <returns>Se encontrando no banco dedos, retorna RespostaAluno referente ao id</returns>
        /// <response code="404">Retorna mensagem informando registro não encontrado com id informado</response>
        /// <response code="400">Retorna informativo de dados inválidos</response>
        [HttpGet("{alunoId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RespostaAluno> GetAlunoById([FromRoute] Guid alunoId)
        {
            if(alunoId.Equals(new Guid())) return Ok();
            if(alunoId.Equals(new Guid())) return NotFound(new { message = $"Aluno com id ${alunoId} não encontrando." });
            else return BadRequest(new { message = $"Dados inválidos." });
        }
    }
}