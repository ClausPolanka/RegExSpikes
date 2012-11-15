using System.Text.RegularExpressions;
using NUnit.Framework;

namespace TimeTests
{
    [TestFixture]
    public class Team_Georg_Michi
    {
        private string timePattern = @"TODO";

        [TestCase("09:30 am")]
        [TestCase("10:00 am")]
        [TestCase("11:59 pm")]
        [TestCase("12:22 am")]
        [TestCase("05:45 pm")]
        public void ValidTime(string time)
        {
            var regex = new Regex("^" + timePattern + "$");

            Assert.IsTrue(regex.IsMatch(time));
        }

        [TestCase("1:22 am")]
        [TestCase("21:22 am")]
        [TestCase("13:22 pm")]
        [TestCase("11:61 pm")]
        [TestCase("11 :11 pm")]
        [TestCase("11: 11 pm")]
        [TestCase("11:11  pm")]
        [TestCase("11:11 xx")]
        public void InvalidTime(string time)
        {
            var regex = new Regex("^" + timePattern + "$");

            Assert.AreNotEqual(timePattern, "TODO");
            Assert.IsFalse(regex.IsMatch(time));
        }
    }
}
