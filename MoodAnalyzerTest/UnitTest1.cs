using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
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
        //Refactor code
        // Refactor TC 1.1 Given “I am in Sad Mood” message Should Return SAD.
        [TestMethod]
        public void GivenSadMood_WhenAnalyse_ShouldReturnSAD()
        {
            string expectedValue = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result = moodAnalyzer.AnalyseMood(message);
            Assert.AreEqual(expectedValue, result);
        }
        // Refactor TC 1.2 Given “I am in Happy Mood” message Should Return SAD.
        [TestMethod]
        public void GivenAnyMood_ShouldReturnHAPPY()
        {
            string expectedValue = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string mood = moodAnalyzer.AnalyseMood(message);
            Assert.AreEqual(expectedValue, mood);
        
        }
    }  
}