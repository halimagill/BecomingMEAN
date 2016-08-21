using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurnerBroadcasting.Repository;

namespace TurnerBroadcasting.Tests
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void Should_Return_All_Titles()
        {
            var titles = TitleRepository.GetAllTitles();

            Assert.IsNotNull(titles);
        }
    }
}