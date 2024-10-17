using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp;
using WpfApp1;

namespace WpfApp.Tests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void TestIsNumeric_WithOnlyDigits_ReturnsTrue()
        {
            var window = new MainWindow();
            Assert.IsTrue(window.IsNumeric("12345"));
        }

        [TestMethod]
        public void TestIsNumeric_WithLetters_ReturnsFalse()
        {
            var window = new MainWindow();
            Assert.IsFalse(window.IsNumeric("123a45"));
        }

        [TestMethod]
        public void TestIsNumeric_WithEmptyString_ReturnsFalse()
        {
            var window = new MainWindow();
            Assert.IsFalse(window.IsNumeric(""));
        }

        [TestMethod]
        public void TestIsNumeric_WithSpecialCharacters_ReturnsFalse()
        {
            var window = new MainWindow();
            Assert.IsFalse(window.IsNumeric("123@45"));
        }
    }
}
