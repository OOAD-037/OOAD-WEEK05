﻿using System;

namespace Animal
{
    class Animal
    {
        public void Eat()
        {

        }
    }
    class Cat : Animal
    {
        public void Meow()
        {

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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
            Console.ReadKey();
        }
    }
}
