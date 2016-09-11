# ANW-ComposerApp
An exercise for adding functionality to an ASP.NET MVC website, in a test-driven way.

To run all tests
----------------
1. In Visual Studio, hit `Debug` > `Start Without Debugging` to start running the app on localhost:55488.
2. Run the tests.

Troubleshooting tests
---------------------
If the tests fail in the setup method, this is usually for one of the following reasons:
* Your installed version of Firefox is higher than v47 - sadly Selenium doesn't support v48 just yet.
* The Selenium NuGet packages which Coypu works with aren't on the latest version. Updating them will fix the issue in this case.
* _NB: Make sure however to NOT upgrade to the lastest version of NUnit, as Coypu does not presently support it!_
