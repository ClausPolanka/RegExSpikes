using System.Text.RegularExpressions;
using NUnit.Framework;

namespace UrlProtocolTests
{
    [TestFixture]
    public class Team_Georg_Michi
    {
        private string urlPattern = @"(^http|^https|^ftp)://\D+(\w{2,3})";  

        [TestCase("http://cpb-software.com")]
        [TestCase("https://cpb-software.de")]
        [TestCase("ftp://google.at")]
        public void ValidUrls(string url)
        {
            var regex = new Regex("^" + urlPattern + "$");

            Assert.IsTrue(regex.IsMatch(url));
        }

        [TestCase("hhtp://cpb-software.com")]
        [TestCase("https:://cpb-software.com")]
        [TestCase("ftp:/cpb-software.com")]
        [TestCase("ftp://cpb-software..com")]
        [TestCase("ftp://cpb-software.de.")]
        [TestCase("ftp://cpb-software.comm")]
        public void InvalidUrls(string url)
        {
            var regex = new Regex("^" + urlPattern + "$");

            Assert.AreNotEqual(urlPattern, "TODO");
            Assert.IsFalse(regex.IsMatch(url));
        }
    }
}
