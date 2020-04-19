using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElelemnt()
        {
            var formatter = new HtmlFormatter();
            string value = "abc";
            var result = formatter.FormatAsBold("abc");

            //specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //more general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

            Assert.That(result, Is.EqualTo($"<strong>{value}</strong>").IgnoreCase );

        }

    }
}
