﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
  public  class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        //Analysing the mood by passing happy Or sad.
        public string AnalyseMood(string message)
        {
            if (this.message.Contains("Sad"))
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
