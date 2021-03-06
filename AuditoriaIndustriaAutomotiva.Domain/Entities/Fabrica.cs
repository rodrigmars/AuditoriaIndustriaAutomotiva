﻿using System;

namespace AuditoriaIndustriaAutomotiva.Domain.Entities
{
    public class Fabrica
    {
        public Fabrica()
        {
            AuditData = DateTime.Now;
        }

        public int FabricaId { get; set; }

        public string Setor { get; set; }

        public DateTime AuditData { get; set; }

        public override string ToString()
        {
            return Setor;
        }
    }
}
