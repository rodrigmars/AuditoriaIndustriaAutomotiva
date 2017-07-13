using System;

namespace AuditoriaIndustriaAutomotiva.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
            AuditData = DateTime.Now;
        }

        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public DateTime AuditData { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
