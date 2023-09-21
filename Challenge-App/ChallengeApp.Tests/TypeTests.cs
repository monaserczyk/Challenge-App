using Challenge_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void WhenNoCapitalLetter_ThenNotTheSameEmployee()
        {
            //arrange
            string employee1 = ("Kasia");
            string employee2 = ("kasia");

            //act
            

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void WhenCreatingNewEmployeeWithTheSameName_ThenNotTheSameEmployee()
        {
            //arrange
            var employee1 = GetEmployee("Kazik");
            var employee2 = GetEmployee("Kazik");
           

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private static Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

        [Test]
        public void WhenTheSameValueInt_ThenIntsAreEqual()
        {
            //arrange
            int number1 = 31;
            int number2 = 31;

            //act
            

            //assert
            Assert.AreEqual(number1, number2);
        }
    }

}
