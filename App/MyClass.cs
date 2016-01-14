using System;

namespace App
{
    public class Person
    {
        public String name;
        public int age;

        public Person()
        {
        }

        public Person(String n, int a)
        {
            name = n;
            age = a;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; age: {1}", name, age);
        }
    }
}

