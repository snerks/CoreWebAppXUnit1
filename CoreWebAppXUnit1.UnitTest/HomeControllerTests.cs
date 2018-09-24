using CoreWebAppXUnit1.Controllers;
using System;
using Xunit;

namespace CoreWebAppXUnit1.UnitTest
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_succeeds()
        {
            // Arrange
            var sut = new HomeController();

            // Act
            var result = sut.Index();

            // Assert
            Assert.Null(result);
        }
    }
}
