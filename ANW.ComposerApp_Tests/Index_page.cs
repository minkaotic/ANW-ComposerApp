using Coypu;
using Coypu.NUnit.Matchers;
using NUnit.Framework;

namespace ANW.ComposerApp_Tests
{
    [TestFixture]
    public class Index_page
    {
        private BrowserSession _browser;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _browser = new BrowserSession(new SessionConfiguration
            {
                AppHost = "localhost",
                Port = 55488
            });
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            _browser.Dispose();
        }

        [Test]
        public void Contains_Audionetwork_header()
        {
            _browser.Visit("/");
            Assert.That(_browser, Shows.Content("Audionetwork"));
        }
    }
}
