using System;

namespace AuditoriaIndustriaAutomotiva.Domain.Entities
{
    public class Material
    {

        public Material()
        {
            AuditData = DateTime.Now;
        }

        public int MaterialId { get; set; }

        public string Descritivo { get; set; }

        public DateTime AuditData { get; set; }

        public override string ToString()
        {
            return Descritivo;
        }

    }
}
