﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            Species = "Dog";
            Name = name;
        }
    }
}
