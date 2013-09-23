using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecflowKata
{
    [Binding]
    public class Add_Feature2_Steps
    {
        string input = string.Empty;
        int result = 0;

        [Given(@"I have a comma delimited (.*) of numbers passed to add")]
        public void GivenIHaveACommaDelimitedPassedToAdd(string p0)
        {
            input = p0;
        }
        
        [When(@"I get the result")]
        public void WhenICalculateTheResult()
        {
            result = Calc.Add(input);
        }
        
        [Then(@"the result is the (.*) of the numbers passed in")]
        public void ThenTheResultIsTheOfTheNumbersPassedIn(string p0)
        {
            int val = int.Parse(p0);
            Assert.AreEqual(val, result);
        
        }
    }
}
