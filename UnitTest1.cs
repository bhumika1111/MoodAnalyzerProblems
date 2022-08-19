using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        //Here we check the Given condition " I am in sad mood should return sad".
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string message = "I am in sad mood ";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);

            //Act 
            string result = moodAnalyze.CheckMood(message);

            //Assert
            Assert.AreEqual("Sad", result);
            

        }
    }
}
