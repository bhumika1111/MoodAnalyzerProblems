using System;
using System.Collections.Generic;
using System.Text;


namespace MoodAnalyzerProb
{
   public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        //Analysing the mood by passing I am in any mood.
        public string CheckMood(string message)
        {
            if (this.message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
