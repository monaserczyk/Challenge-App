using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Challenge_App.EmployeeBase;

namespace Challenge_App
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        char Gender { get; }
        int Age { get; }

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(string grade);
        void AddGrade(char grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
