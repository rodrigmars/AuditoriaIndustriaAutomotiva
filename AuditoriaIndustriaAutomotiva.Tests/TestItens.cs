using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AuditoriaIndustriaAutomotiva.Tests
{
    public class TestItens
    {

        [Fact]
        public void VerificaItemDeVenda() {

            var ItemVendaId = 15;

            Assert.Equal(15, ItemVendaId);
        }
    }
}
