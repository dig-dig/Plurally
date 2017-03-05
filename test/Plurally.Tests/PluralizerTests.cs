using Xunit;
using System.Globalization;

namespace Plurally.Tests
{
    public class PluralizerTests
    {
        //[Fact]
        //public void PlurallyShouldThrowNotSupportedForUnassignedLocales()
        //{
        //    Assert.Catch(() =>
        //    {
        //        new Pluralizer(new CultureInfo(23));
        //    });
        //}

        [Fact]
        public void PlurallyShouldUseSameEnglishLocaleForAll()
        {
            var plurallyGB = new Pluralizer(new CultureInfo("en-GB"));
            var plurallyUS = new Pluralizer(new CultureInfo("en-US"));

            // Assert the results are the same on the pluralization
            var pluralGB = plurallyGB.Pluralize("test");
            var pluralUS = plurallyUS.Pluralize("test");

            // Same results for English
            Assert.Equal(pluralGB, pluralUS);
        }
    }
}

