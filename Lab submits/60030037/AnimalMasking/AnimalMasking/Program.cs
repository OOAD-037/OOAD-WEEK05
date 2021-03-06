﻿using System;

namespace AnimalMasking
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating..");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("dog big barking...");
        }
    }
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
        new public void Bark()
        {
            Console.WriteLine("puppy small bark...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Puppy puppy = new Puppy();
            dog.Bark();
            puppy.Bark();
            Console.ReadKey();
        }
    }
}
