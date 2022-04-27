using System;

namespace Domain.Models
{
    public class Alunos
    {
        public Guid AlunoId { get; private set; }
        public string CPF { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public Guid Curso { get; private set; }
        public DateTime Nascimento { get; private set; }
    }
}