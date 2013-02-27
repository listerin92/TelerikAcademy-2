﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public static int CompareGrades(Student one, Student two)
        {
            return one.Grade.CompareTo(two.Grade);
        }

    }
}
