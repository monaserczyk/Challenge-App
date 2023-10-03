namespace Challenge_App
{
    public record Employee(string Name, string Surname)
    {
        public List<float> grades = new List<float>();

        public string Name { get; private set; } = Name;
        public string Surname { get; private set; } = Surname;



        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value!");                
            }

        }
        public void AddGrade(int grade)
        {
            float ValueInInt = (float)grade;
            this.grades.Add(ValueInInt);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float!");
            }
        }
        public void AddGrade(double grade)
        {
            float ValueInDbl = (float)Math.Ceiling(grade);
            this.AddGrade(ValueInDbl);

        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.grades.Add(100);
                    break;
                case 'B' or 'b':
                    this.grades.Add(80);
                    break;
                case 'C' or 'c':
                    this.grades.Add(60);
                    break;
                case 'D' or 'd':
                    this.grades.Add(40);
                    break;
                case 'E' or 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter !");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {

                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }
            return statistics;
        }


    }
}