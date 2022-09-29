using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer()
        {
        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException ex)
            {
                return "HAPPY";
            }
        }
    }
}
    

