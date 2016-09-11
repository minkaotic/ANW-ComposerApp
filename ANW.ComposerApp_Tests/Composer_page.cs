using System.Linq;
using Coypu;
using Coypu.NUnit.Matchers;
using NUnit.Framework;

namespace ANW.ComposerApp_Tests
{
    class Composer_page
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
        public void Shows_details_of_a_given_composer()
        {
            var testComposer = ComposerRepo.Composers.First();
            _browser.Visit("/Home/Composer/" + testComposer.Id);

            Assert.That(_browser, Shows.Content(testComposer.Title));
            Assert.That(_browser, Shows.Content(testComposer.FirstName));
            Assert.That(_browser, Shows.Content(testComposer.LastName));
            Assert.That(_browser, Shows.Content(testComposer.Awards));
        }
    }
}
