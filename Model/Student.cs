﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public string Name { set; get; }
        public string Speciality { set; get; }
        public string Group { set; get; }
        public Student(string name, string group, string speciality)
        {
            Name = name;
            Speciality = speciality;
            Group = group;
        }
    }
}
