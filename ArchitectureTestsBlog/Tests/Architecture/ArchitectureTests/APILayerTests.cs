using System.Reflection;
using FluentAssertions;
using NetArchTest.Rules;

namespace ArchitectureTests
{
    public class APILayerTests
    {
        [Test]
        public void APILayer_Should_Not_Access_Repository_Layer_Directly()
        {
            var result = Types.InAssembly(Assembly.Load("ArchitectureAPI"))
                .That()
                .ResideInNamespace("ArchitectureAPI.Controllers")
                .ShouldNot()
                .HaveDependencyOn("DataAccess")
                .GetResult();

            result.IsSuccessful.Should().Be(true);
        }
    }
}