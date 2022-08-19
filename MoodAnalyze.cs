using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
   public class MoodAnalyze
    {
        private string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        //Analysing the mood by passing happy or sad.
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
