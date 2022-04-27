using System;

namespace API.DTOs.Alunos
{
    public class RespostaAluno
    {
        public Guid AlunoId { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public Guid CursoId { get; private set; }
    }
}