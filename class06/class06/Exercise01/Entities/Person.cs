﻿using Exercise01.Enum;

namespace Exercise01.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }
        public override string Info()
        {
            return $"{Id}) {FirstName} {LastName} - {Age} years old with Job {Occupation} ";
        }
    }
}
