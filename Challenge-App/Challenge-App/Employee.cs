using System.Diagnostics.Metrics;

namespace Challenge_App
{
    public class Employee
    {
        public List<int> score = new();

        public Employee(string name)
        {
            this.Name = name;
        }
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
           
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public int Score { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }
        public void AddScore(int score) 
        { 
            this.score.Add(score); 
        }

        public void SubtractScore(int score)
        {
            this.score.Add(-score);
        }

        public void AddBonusScore(int score) 
        {
            this.score.Add(2 * score);
        }
    }

}

