using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        [DataRow("I am in happy mood", "happy")]
        public void Given_Message_Should_Return_User_Mood(string message, string expected)
        {
            MoodAnalyser mood = new MoodAnalyser(message);//Arrange
            string actual = mood.AnalyseMood();//Act
            Assert.AreEqual(expected, actual);//Assert
        }

        [TestMethod]
        //[DataRow(null, "happy")]
        public void Given_null_Message_Should_Return_User_Exception()
        {
            string message = null;
            string expected = "Message is having null";
            try
            {
                MoodAnalyser mood = new MoodAnalyser(message);
                string actual = mood.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            catch(CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
