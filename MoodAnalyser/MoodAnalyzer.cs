using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        public  MoodAnalyzer()
        {

        }
        /// <summary>
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
    }
}
    

