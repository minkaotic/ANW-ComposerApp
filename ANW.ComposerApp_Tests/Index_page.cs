using System.Linq;
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
        public void Shows_Audionetwork_header()
        {
            _browser.Visit("/");

            Assert.That(_browser, Shows.Content("Audionetwork"));
        }

        [Test]
        public void Shows_a_list_of_all_composers_and_their_full_name()
        {
            _browser.Visit("/");

            foreach (var composer in ComposerRepo.Composers)
            {
                var composerName = composer.FirstName + " " + composer.LastName;
                Assert.That(_browser, Shows.Content(composerName));
            }
        }

        [Test]
        public void Shows_the_total_number_of_composers_returned()
        {
            _browser.Visit("/");

            Assert.That(_browser, Shows.Content("We presently work with " + ComposerRepo.Composers.Count() + " composers"));
        }
    }
}
