using Challenge_App;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenPointsAdded_ThenSumCorrect()
        {
            //arrange
            var employee = new Employee("Alex", "Matus", "38");
            employee.AddScore(8);
            employee.AddScore(5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(13, result);
        }

        [Test]

        public void WhenMinusPointsAdded_ThenSumCorrect()
        {
            //arrange
            var employee = new Employee("Justyna", "Lala", "23");
            employee.AddScore(20);
            employee.SubtractScore(8);
            employee.SubtractScore(5);
            
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(7, result);
        }

        [Test]

        public void WhenBonusPointsAdded_ThenSumCorrect()
        {
            //arrange
            var employee = new Employee("Saga", "Blekken", "30");
            employee.AddScore(4);
            employee.AddScore(3);
            employee.AddBonusScore(8);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(23, result);
        }
    }
}