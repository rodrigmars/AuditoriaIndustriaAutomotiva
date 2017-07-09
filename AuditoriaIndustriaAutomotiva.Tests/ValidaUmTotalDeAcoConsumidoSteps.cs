using System;
using TechTalk.SpecFlow;
using Xunit;

namespace AuditoriaIndustriaAutomotiva.Tests
{
    [Binding]
    public class ValidaUmTotalDeAcoConsumidoSteps
    {

        DateTime _today { get; set; }
        int _totalLote { get; set; }
        int _percentual { get; set; }
        int _total { get; set; }

        [Given(@"que a fábrica recebe (.*) lotes de aço para consumo diário")]
        public void DadoQueAFabricaRecebeLotesDeAcoParaConsumoDiario(int totalLote)
        {
            _totalLote = totalLote;
        }
        
        [Given(@"foram cosnumidos (.*)% destes lotes na data (.*)")]
        public void DadoForamCosnumidosDestesLotesNaData(int percentual, DateTime today)
        {
            Console.WriteLine($"Percentual: { percentual }");
            Console.WriteLine($"Today: { today }");

            _percentual = percentual;
            _today = today;
        }
        
        [When(@"a fábrica for validar a quantidade de aço usado nesta data")]
        public void QuandoAFabricaForValidarAQuantidadeDeAcoUsadoNestaData()
        {
            _total = (int)Math.Round(_totalLote * ((double)_percentual / 100), 0);
        }
        
        [Then(@"á quantidade esperada será de (.*) lotes consumidos")]
        public void EntaoAQuantidadeEsperadaSeraDeLotesConsumidos(int total)
        {
            Assert.Equal(total, _total);
        }
    }
}
