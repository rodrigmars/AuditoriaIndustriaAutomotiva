﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AuditoriaIndustriaAutomotiva.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ValidaUmTotalDeAcoConsumidoFeature : Xunit.IClassFixture<ValidaUmTotalDeAcoConsumidoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        public ValidaUmTotalDeAcoConsumidoFeature(ValidaUmTotalDeAcoConsumidoFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Valida um total de aço consumido", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="SimulaConsumoDeAço")]
        [Xunit.TraitAttribute("FeatureTitle", "Valida um total de aço consumido")]
        [Xunit.TraitAttribute("Description", "SimulaConsumoDeAço")]
        [Xunit.TraitAttribute("Category", "mytag")]
        public virtual void SimulaConsumoDeAco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulaConsumoDeAço", new string[] {
                        "mytag"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("que a fábrica recebe 50 lotes de aço para consumo diário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 6
 testRunner.And("foram cosnumidos 10% destes lotes na data 15/05/2017", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 7
 testRunner.When("a fábrica for validar a quantidade de aço usado nesta data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 8
 testRunner.Then("á quantidade esperada será de 5 lotes consumidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ValidaUmTotalDeAcoConsumidoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ValidaUmTotalDeAcoConsumidoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
