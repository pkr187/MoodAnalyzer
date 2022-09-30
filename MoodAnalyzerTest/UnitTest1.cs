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
        //UC 2
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
        //UC 3
        //TC 3.1: Given NULL Mood Should Throw MoodAnalysisException
        [TestMethod]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            try
            {
                string actutal = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        //UC 3
        //TC 3.2: Given EMPTY Mood Should Throw MoodAnalysisException indicating Empty Mood
        [TestMethod]
        public void GivenEmptylMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = string.Empty;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            try
            {
                string actual = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        //UC 4
        //TC 4.1: Given MoodAnalyze Class Name Should Return MoodAnalyzer Object
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerAppWithCore.MoodAnalyser", "MoodAnalyZer");
            expected.Equals(obj);
            //Assert.AreEqual(expected, obj);
        }
    }
}

