namespace Challenge_App.Tests
{
    public class NewTests
    {
        [Test]
        public void StatisticsCheck_WhenGradeIsChar()
        {
            var employee = new Employee("Marta", "Ladny");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('B');
            employee.AddGrade('D');
            var statistics = employee.GetStatistics();
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(40, statistics.Min);
            Assert.AreEqual(75, statistics.Average);

        }
        [Test]
        public void StatisticsCheck_WhenGradeIsMixed()
        {
            var employee = new Employee("Luiza", "Tralla");
            employee.AddGrade('A');
            employee.AddGrade(21);
            employee.AddGrade("46");
            employee.AddGrade(8);
            employee.AddGrade('C');
            var statistics = employee.GetStatistics();
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(8, statistics.Min);
            Assert.AreEqual(47, statistics.Average);

        }
    }
}
