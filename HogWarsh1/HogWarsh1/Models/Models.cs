﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HogWarsh1.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string House { get; set; }
    }

    public class House
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class InMemoryDatabase
    {
        public static List<House> Houses { get; private set; }
        public static List<Student> Students { get; private set; }

        static InMemoryDatabase()
        {
            Houses = new List<House>() {
                new Models.House() {
                    Name="Garfieldor",
                    Description="Furry Feline Unfrenzy"
                },
                new House()
                {
                    Name="Odiferous",
                    Description = "Wagabonds"
                }
            };
            Students = new List<Student> { };
        }

        internal static List<House> GetAllHouses()
        {
            // this would become something that talks to the real database
            return Houses; 
        }
    }

}