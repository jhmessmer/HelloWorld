﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a change to the project.");
            Console.WriteLine("The sky is blue, which is cool.");
            Console.WriteLine("This is yet another change.");
        }
    }

    class Student
    {
        private int studentId;
        private string fName;
        private string lName;
        private string major;
    }

    class Faculty
    {
        private int facultyId;
        private string fName;
        private string lName;
        private int rating;
    }
}
