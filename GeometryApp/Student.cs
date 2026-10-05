using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryApp
{
    internal class Student
    {
        private string fullName;
        private int facultyNumber;
        private string specialty;
        private string year;

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (value.Length >= 3)
                {
                    fullName = value;
                }
            }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value > 0)
                {
                    facultyNumber = value;
                }
            }
        }

        public string Specialty
        {
            get { return specialty; }
            set
            {
                if (value.Length >= 3)
                {
                    specialty = value;
                }
            }
        }

        public string Year
        {
            get { return year; }
            set
            {
                if (value.Length >= 3)
                {
                    year = value;
                }
            }
        }

        public Student()
        {
            FullName = "Unknown";
            FacultyNumber = 1;
            Specialty = "Unknown";
            Year = "1st";
        }

        public Student(string fullName, int facultyNumber, string specialty, string year)
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
            Specialty = specialty;
            Year = year;
        }

        public Student(string fullName, int facultyNumber)
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
            Specialty = "Unknown";
            Year = "1st";
        }

        public void ShowInfo()
        {
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Faculty Number: " + FacultyNumber);
            Console.WriteLine("Specialty: " + Specialty);
            Console.WriteLine("Year: " + Year);
        }
    }
}
