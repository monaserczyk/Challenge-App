namespace Challenge_App
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, char gender, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}
      