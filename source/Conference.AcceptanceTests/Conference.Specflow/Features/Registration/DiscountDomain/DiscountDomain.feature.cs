﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.DiscountDomain
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DiscountsFeature : Xunit.IUseFixture<DiscountsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DiscountDomain.feature"
#line hidden
        
        public DiscountsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Discounts", "In order to save money\r\nAs a conference attendee\r\nI want to be able to use discou" +
                    "nt codes", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(DiscountsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Discounts")]
        [Xunit.TraitAttribute("Description", "Add discount code to conference")]
        public virtual void AddDiscountCodeToConference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add discount code to conference", new string[] {
                        "discount"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("the event of creating a conference has occurred");
#line 9
 testRunner.When("the command to create a discount is received");
#line 10
 testRunner.Then("the event of that discount being created is emmitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Discounts")]
        [Xunit.TraitAttribute("Description", "Get a percentage discount")]
        public virtual void GetAPercentageDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a percentage discount", new string[] {
                        "discount"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("the event of creating a conference has occurred");
#line 15
 testRunner.And("the event of adding a discount with scope all for 20 % has occurred");
#line 16
 testRunner.When("the command to apply this discount to a total of $1000 is received");
#line 17
 testRunner.Then("the event $200 discount has been applied is emmitted");
#line 18
    testRunner.And("the event corresponds to the discount requested");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Discounts")]
        [Xunit.TraitAttribute("Description", "Can\'t get a percentage discount twice")]
        public virtual void CanTGetAPercentageDiscountTwice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can\'t get a percentage discount twice", new string[] {
                        "discount"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("the event of creating a conference has occurred");
#line 23
 testRunner.And("the event of adding a discount has occurred");
#line 24
 testRunner.And("the event of redeeming this discount has occurred");
#line 25
 testRunner.When("the command to apply this discount to any total is received");
#line 26
 testRunner.Then("a Discounts.Exceptions.DiscountAlreadyAppliedException is raised");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Discounts")]
        [Xunit.TraitAttribute("Description", "Get a different percentage discount")]
        public virtual void GetADifferentPercentageDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a different percentage discount", new string[] {
                        "discount"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("the event of creating a conference has occurred");
#line 31
 testRunner.And("the event of adding a discount with scope all for 50 % has occurred");
#line 32
 testRunner.When("the command to apply this discount to a total of $1000 is received");
#line 33
 testRunner.Then("the event $500 discount has been applied is emmitted");
#line 34
    testRunner.And("the event corresponds to the discount requested");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DiscountsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DiscountsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
