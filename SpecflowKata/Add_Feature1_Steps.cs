using System;
using TechTalk.SpecFlow;
using NUnit.Core;
using NUnit.Core.Extensibility;
using NUnit.Core.Filters;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace SpecflowKata
{
    [Binding]
    public class Add_Feature1_Steps
    {
        string input = string.Empty;
        int result = 0;

        [Given(@"I an empty string")]
        public void GivenIAnEmptyString()
        {
            input = "";
            //ScenarioContext.Current.Pending();
        }

        [When(@"I pass the string to add")]
        public void WhenIPassTheStringToAdd()
        {
            result = Calc.Add("");
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the result is zero")]
        public void ThenTheResultIs()
        {
            Assert.AreEqual(0, result);
            //ScenarioContext.Current.Pending();
        }
    }
}
