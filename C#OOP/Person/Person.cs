﻿using System;

namespace Person
{
    public class Person
    {
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public virtual int Age 
        { 
            get => age;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be negative.");
                }

                age = value;
            }
        }


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}".ToString();
        }
    }
}
