using System.Text.RegularExpressions;
using NUnit.Framework;

namespace DollarTests
{
    [TestFixture]
    public class Team_Christoph_Rupert
    {
        private string dollarPattern = @"\$([^0\d+]|0)?(.\d\d)?";

        [TestCase("$12")]
        [TestCase("$1.00")]
        [TestCase("$20.11")]
        [TestCase("$100.42")]
        [TestCase("$1")]
        [TestCase("$.99")]
        [TestCase("$0.99")]
        public void ValidDollars(string input)
        {
            var regex = new Regex("^" + dollarPattern + "$");

            Assert.IsTrue(regex.IsMatch(input));
        }

        [TestCase("$00")]
        [TestCase("$1.100")]
        [TestCase("$")]
        [TestCase("$01")]
        public void InvalidDollars(string input)
        {
            var regex = new Regex("^" + dollarPattern + "$");

            Assert.AreNotEqual(dollarPattern, "TODO");
            Assert.IsFalse(regex.IsMatch(input));
        }

    }
}
