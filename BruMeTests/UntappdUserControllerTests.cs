using Rhino.Mocks;
using NUnit.Framework;
using BruMeServices;
using BruMeDomainObjects.BruMeObjects;

namespace BruMeTests
{
    [TestFixture]
    public class UntappdUserControllerTests
    {
        /*
            Code to test a static object, if needed.
            var untappdRequestMock = Mock.Create<UntappdRequest>();
            Mock.Arrange(() => untappdRequestMock.GetUntappdUserInfo("Delphi53")).Returns(SampleJSONUserInfoResponse.Get());
            UntappdUserServices service = Mock.Create<UntappdUserServices>(Behavior.CallOriginal);
            Mock.NonPublic.Arrange<UntappdRequest>(service, "UntappdRequest").Returns(untappdRequestMock);
        */

        [Test]
        public static void GetUntappdUserInfo_ReturnsUserStatsAndRecentBeers()
        {
            //Arrange
            UntappdRequest untappdRequestMock = MockRepository.GenerateMock<UntappdRequest>();
            untappdRequestMock.Expect(m=> m.GetUntappdUserInfo(Arg<string>.Is.Anything)).Return(SampleJSONUserInfoResponse.GetMockResponse());
            UntappdUserServices service = new UntappdUserServices(untappdRequestMock);
            //IUntappdUserServices service = MockRepository.GeneratePartialMock<UntappdUserServices>();
            //service.Expect(m => m.untappdRequest).Return((UntappdRequest)untappdRequestMock);

            //Act
            BruMeUser bruMeUser = service.GetUntappdUserInfo("Delphi53");

            //Assert
            Assert.AreEqual("Delphi53", bruMeUser.UserName);
            Assert.AreEqual(349, bruMeUser.Stats.TotalCheckins);
            Assert.AreEqual(5, bruMeUser.RecentBrews.Count);
        }
    }
}
