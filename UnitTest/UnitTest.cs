using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParenthesisChecker;

namespace ParenthesisCheckerTests
{
    [TestClass]
    public class ParenthesisCheckerTests
    {
        [TestMethod]
        public void TestSingleTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.Program.IsBalanced("()"));
            Assert.IsTrue(ParenthesisChecker.Program.IsBalanced("{}"));
            Assert.IsTrue(ParenthesisChecker.Program.IsBalanced("[]"));
        }

        [TestMethod]
        public void TestSingleTypeUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.Program.IsBalanced("("));
            Assert.IsFalse(ParenthesisChecker.Program.IsBalanced("}"));
            Assert.IsFalse(ParenthesisChecker.Program.IsBalanced("["));
        }

        [TestMethod]
        public void TestMixedTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.Program.IsBalanced("{[()]}"));
            Assert.IsTrue(ParenthesisChecker.Program.IsBalanced("[{()}]"));
        }

        [TestMethod]
        public void TestMixedTypeUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.Program.IsBalanced("{[(])}"));
            Assert.IsFalse(ParenthesisChecker.Program.IsBalanced("{[}"));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(ParenthesisChecker.Program.IsBalanced(""));
        }
    }
}

