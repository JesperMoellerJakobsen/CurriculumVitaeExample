using CurriculumVitae.Database;
using CurriculumVitae.DomainModels.DummyData;
using Moq;
using Xunit;

namespace CurriculumVitae.Test.DatabaseContext
{
    public class CurriculumVitaeDatabaseContextTest
    {
        [Fact]
        public void CurriculumVitaeContextShouldUseFactory()
        {
            var dummyDataFactoryMoc = new Mock<IDummyDataFactory>();
            var sut = new CurriculumVitaeDatabaseContext(dummyDataFactoryMoc.Object);

            sut.DetailedUserInformation();

            //All dependencies should be called. Data output is tested in factory test
            dummyDataFactoryMoc.Verify(m => m.MakeUser());
            dummyDataFactoryMoc.Verify(m => m.MakeCompanies());
            dummyDataFactoryMoc.Verify(m => m.MakeEducations());
            dummyDataFactoryMoc.Verify(m => m.MakeProjects());
            dummyDataFactoryMoc.Verify(m => m.MakeSkills());
        }
    }
}
