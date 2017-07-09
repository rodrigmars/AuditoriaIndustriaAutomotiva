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
