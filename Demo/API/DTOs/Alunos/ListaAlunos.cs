using System.Collections.Generic;

namespace API.DTOs.Alunos
{
    public class ListaAlunos
    {
        public IEnumerable<RespostaAluno> Alunos { get; set; }
    }
}