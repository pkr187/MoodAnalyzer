using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary> TC 1.1
        /// Givens the I am in any mood should return Happy.
        /// </summary>
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnSad()
        {
            //Arrange
            string message = "I am in Sad Mood.";
            string expectedValue = "SAD";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyzer.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        /// <summary> TC 1.2
        /// Givens the I am in any mood should return Happy.
        /// </summary>
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnHappy()
        {
            //Arrange
            string message = "I am in Happy Mood.";
            string expectedValue = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyzer.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}