using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        public MoodAnalyzer()
        {

        }
        /// <summary> UC 1
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyses user's mood.
        /// </summary>
        /// <param name="message">The message</param>
        /// <returns>Sad else Happy</returns>
        public string AnalyseMood(string message)
        {
            ///Checks if user mood is sad will return sad,
            ///if user mood is happy will return happy.
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        //UC 2
        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException ex)
            {
                return "HAPPY";
            }
        }
        //UC 3
        public string MoodAnalyse()
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Message is Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalysisException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Message is ull");
            }
        }
    }
}
    

