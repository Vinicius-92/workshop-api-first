using System;

namespace Domain.Models
{
    public class Curso
    {
        public Guid CursoId { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public Guid ResponsavelId { get; private set; }
    }
}