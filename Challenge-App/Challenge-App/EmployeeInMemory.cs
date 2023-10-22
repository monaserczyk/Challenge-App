namespace Challenge_App
{
    public class EmployeeInMemory : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        public List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, char gender, int age)
            : base(name, surname, gender, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Use value 0 - 100!");
            }
        }
        public override void AddGrade(double grade)
        {
            float valueInDbl = (float)Math.Ceiling(grade);
            this.AddGrade(valueInDbl);
        }
        public override void AddGrade(int grade)
        {
            float valueInInt = (float)grade;
            this.AddGrade(valueInInt);
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                if (result >= 0 && result <= 100)
                {
                    this.AddGrade(result);
                }
                else if (char.TryParse(grade, out char charResult))
                {
                    this.AddGrade(charResult);
                }
                else
                {
                    throw new Exception("String is not a valid float!");
                }
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter !");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
