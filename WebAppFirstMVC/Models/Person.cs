using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFirstMVC.Models
{
    public class Person
    {
        public static List<Person> People { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

    }
}