namespace Hangman.Logic.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var w = new Word("Welcome");
            Assert.IsTrue(w.GuessLetter("w"));
        }
    }
}
