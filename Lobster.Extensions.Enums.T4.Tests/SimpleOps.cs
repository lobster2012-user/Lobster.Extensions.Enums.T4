using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Lobster.Extensions.Enums.T4.Tests
{
    [TestClass]
    public class SimpleOps
    {
        [TestMethod]
        public void Test_Set()
        {
            Assert.AreEqual(
                FileAccess.Read.Set(FileAccess.Write),
                FileAccess.ReadWrite);
        }
        [TestMethod]
        public void Test_Clear()
        {
            Assert.AreEqual(
                FileAccess.ReadWrite.Reset(FileAccess.Write),
                FileAccess.Read);
        }
        [TestMethod]
        public void Test_IsAnySet()
        {
            Assert.IsTrue(
                (FileAccess.ReadWrite).IsAnySet(FileAccess.Read));
            Assert.IsFalse(
                (FileAccess.Write).IsAnySet(FileAccess.Read));
            Assert.IsTrue(
              (FileAccess.Write).IsAnySet(FileAccess.Read| FileAccess.Write));
        }
        [TestMethod]
        public void Test_AreAllSet()
        {
            Assert.IsFalse(
                (FileAccess.Read).AreAllSet(FileAccess.ReadWrite));
            Assert.IsTrue(
                (FileAccess.ReadWrite).AreAllSet(FileAccess.ReadWrite));
        }

        [TestMethod]
        public void Test_ContainsOnlyAnyOf()
        {
            Assert.IsTrue(
                (FileShare.Read).ContainsOnlyAnyOf(FileShare.ReadWrite));

            Assert.IsFalse(
                (FileShare.Delete| FileShare.ReadWrite)
                .ContainsOnlyAnyOf(FileShare.ReadWrite));
        }
    }
}
