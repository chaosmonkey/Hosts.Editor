using ChaosMonkey.Guards;
using Hosts.Editor.Domain;
using Moq;
using NUnit.Framework;

namespace Hosts.Editor.Tests
{
    [TestFixture]
    public class HostsFileTests
    {
        private Mock<IFileManager> _mockFileManager;

        [SetUp]
        public void SetUp()
        {
            _mockFileManager = new Mock<IFileManager>();
        }

        [TearDown]
        public void TearDown()
        {
            _mockFileManager = null;
        }

        [Test]
        public void Instantiation_WithNullFileManager_ThrowsGuardException()
        {
            Assert.Throws<GuardException>(() => CreateSut(null));
        }

        [Test]
        public void DefaultFileExists_WhenFileExists_ReturnsTrue()
        {
            _mockFileManager.Setup(mock => mock.CheckIfFileExists(It.Is<string>(n => n == HostsFile.DefaultLocation))).Returns(true);
            var sut = CreateSut();

            Assert.IsTrue(sut.DefaultFileExists);
        }

        [Test]
        public void DefaultFileExists_WhenFileDoesNotExists_ReturnsFalse()
        {
            _mockFileManager.Setup(mock => mock.CheckIfFileExists(It.Is<string>(n => n == HostsFile.DefaultLocation))).Returns(false);
            var sut = CreateSut();

            Assert.IsFalse(sut.DefaultFileExists);
        }

        private HostsFile CreateSut()
        {
            return CreateSut(_mockFileManager.Object);
        }

        private HostsFile CreateSut(IFileManager fileManager)
        {
            return new HostsFile(fileManager);
        }
    }
}
