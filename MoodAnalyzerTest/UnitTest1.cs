using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC2
        // TC 2.1: Given null mood Should Return HAPPY
        [TestMethod]
        public void GivenNullMoodShouldReturnHAPPY()
        {
            string expected = "HAPPY";
            string message = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string mood = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}