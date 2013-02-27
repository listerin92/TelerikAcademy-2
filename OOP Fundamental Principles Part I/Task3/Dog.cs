﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Dog : Animal
    {
        public Dog(int age, string name, char sex)
            : base(age, name, sex)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine(Name + " says bau.");
        }

    }
}
