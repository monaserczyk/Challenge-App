﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_App
{
    public abstract class Person 
    {
      public Person(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
          
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set;}  
        public int Age { get; private set;}
        
    }
}
