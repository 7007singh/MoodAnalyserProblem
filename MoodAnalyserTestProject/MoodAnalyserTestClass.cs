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
        [DataRow("I am in SAD mood", "sad")]
        public void Given_Message_Should_Return_User_Mood(string message, string expected)
        {
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
    }
}
