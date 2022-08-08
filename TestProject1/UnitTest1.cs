using MoodAnalyserProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad() // this method is used to check whether the expected mood and actual mood match or not
        {
            string expected = "SAD";
            string message = "I am in sad mood.";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message); //created object and passed the message to MoodAnalyser Constructor
            string mood = moodAnalyser.AnalyseMood(); //the value return from AnalyseMood method is stored in mood
            Assert.AreEqual(expected, mood); // checking whether both values are equal or not
        }

        [TestMethod]
        [DataRow(null)]
        public void GivenMoodHappyShouldReturnHappy(string message) // this method is for invalid mood like null value
        {
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);

        }
    }
}