using Xunit;
using Plurally.Localization;
using System;
using System.Globalization;

namespace Plurally.Tests
{

    public class PlurallyCulturesTests
    {
        [Fact]
        public void IsPluralShouldCheckNormalWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsPlural("Tests"));
            Assert.Equal(false, plurally.IsPlural("Test"));
        }

        [Fact]
        public void IsPluralShouldCheckSpecialSuffix()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsPlural("elves"));
        }

        [Fact]
        public void IsPluralShouldCheckSpecialWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsPlural("brothers"));
            Assert.Equal(true, plurally.IsPlural("brethren"));
            Assert.Equal(false, plurally.IsPlural("brother"));
        }

        [Fact]
        public void IsPluralShouldCheckUnusualWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsPlural("homework"));
        }

        [Fact]
        public void IsSingularShouldCheckNormalWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsSingular("test"));
            Assert.Equal(false, plurally.IsSingular("tests"));
        }

        [Fact]
        public void IsSingularShouldCheckSpecialSuffix()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsSingular("chess"));
        }

        [Fact]
        public void IsSingularShouldCheckSpecialWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal(true, plurally.IsSingular("Brother"));
            Assert.Equal(false, plurally.IsSingular("brethren"));
            Assert.Equal(false, plurally.IsSingular("brothers"));
        }

        [Fact]
        public void PluralizeShouldCheckSuffixes()
        {
            var plurally = new Pluralizer();
            Assert.Equal("Companies", plurally.Pluralize("Company"));
        }

        [Fact]
        public void PluralizeShouldAddSToNormalWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal("Tests", plurally.Pluralize("Test"));
        }

        [Fact]
        public void PluralizeShouldCheckUnusualWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal("Homework", plurally.Pluralize("Homework"));
        }

        [Fact]
        public void PluralizeShouldCheckSpecialWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal("BROTHERS", plurally.Pluralize("BROTHER"));
        }

        [Fact]
        public void SingularizeShouldRemoveSFromNormalWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal("Test", plurally.Singularize("Tests"));
            Assert.Equal("test", plurally.Singularize("testS"));
        }

        [Fact]
        public void SingularizeShouldCheckUnusualWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal("homework", plurally.Singularize("homework"));
        }

        [Fact]
        public void SingularizeShouldCheckSuffixes()
        {
            var plurally = new Pluralizer();
            Assert.Equal("Company", plurally.Singularize("Companies"));
        }

        [Fact]
        public void SingularizeShouldCheckSpecialWords()
        {
            var plurally = new Pluralizer();
            Assert.Equal("brother", plurally.Singularize("brothers"));
            Assert.Equal("brother", plurally.Singularize("brethren"));
        }            
    }
}

