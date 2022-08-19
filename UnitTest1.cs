using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProb;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        //Here we check the Given condition " I am in any mood should return Happy".
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
                string message = "I am in happy mood ";
               string expected = "Happy";
                MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

                //Act 
                string result = moodAnalyze.CheckMood(message);

                //Assert
                Assert.AreEqual(expected, result);

            }
        }
}
