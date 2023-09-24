namespace Challenge_App.Tests
{
    public class Tests
    {
        [Test]
        public void WhenTheSameNameAndSurname_ThenNotTheSameEmployee()
        {
            var employee1 = new Employee("Katarzyna","Nowak");
            var employee2 = new Employee("Katarzyna", "Nowak");

            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]

        public void CheckStatisticsValues()
        {
            var employee = new Employee("Jolanta", "Kowalski");
            employee.AddGrade(8);
            employee.AddGrade(9);
            employee.AddGrade(-4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, -4);
            Assert.AreEqual(statistics.Max, 9);
            Assert.AreEqual(statistics.Average, 4, 33);
        }
    }
}