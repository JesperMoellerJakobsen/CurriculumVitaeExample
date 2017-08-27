using System;
using CurriculumVitae.Database;
using CurriculumVitae.DomainModels.DummyData;
using Moq;
using Xunit;

namespace CurriculumVitae.Test.DomainModels
{
    public class DummyDataFactoryTest
    {
        private readonly DummyDataFactory sut;
        public DummyDataFactoryTest()
        {
            sut = new DummyDataFactory();
        }

        [Fact]
        public void FactoryShouldProvideUser()
        {
            var result = sut.MakeUser();
            Assert.NotEmpty(result.FirstName);
            Assert.NotEmpty(result.LastName);
            Assert.NotEmpty(result.Email);
        }

        [Fact]
        public void FactoryShouldProvideCompanies()
        {
            var result = sut.MakeCompanies();
            Assert.All(result, item =>
            {
                Assert.NotEmpty(item.Description);
                Assert.NotEmpty(item.CompanyName);
                Assert.NotEmpty(item.Position);
                Assert.NotSame(item.End, default(DateTime));
                Assert.NotSame(item.Start, default(DateTime));
            });
        }

        [Fact]
        public void FactoryShouldProvideEducations()
        {
            var result = sut.MakeEducations();
            Assert.All(result, item =>
            {
                Assert.NotEmpty(item.Description);
                Assert.NotSame(item.End, default(DateTime));
                Assert.NotSame(item.Start, default(DateTime));
            });
        }

        [Fact]
        public void FactoryShouldProvideProjects()
        {
            var result = sut.MakeProjects();
            Assert.All(result, item =>
            {
                Assert.NotEmpty(item.Description);
                Assert.NotSame(item.End, default(DateTime));
                Assert.NotSame(item.Start, default(DateTime));
            });
        }

        [Fact]
        public void FactoryShouldProvideSkills()
        {
            var result = sut.MakeSkills();
            Assert.All(result, item =>
            {
                Assert.NotEmpty(item.Description);
            });
        }
    }
}
