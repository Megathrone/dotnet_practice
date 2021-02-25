using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace language_basic
{
    public class CollectionsPrac
    {
        public static void Main()
        {
            var elements = BuildList();
            var subset =
                from ele in elements
                where ele.AtomicNumber < 22
                orderby ele.Name
                select ele;

            foreach (var element in subset)
            {
                Console.WriteLine(element.Name + " " + element.AtomicNumber);
            }
        }

        private static void m1()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() {Name = "Tadpole", MegaLightYears = 400},
                new Galaxy() {Name = "Pinwheel", MegaLightYears = 25},
                new Galaxy() {Name = "Milky Way", MegaLightYears = 0},
                new Galaxy() {Name = "Andromeda", MegaLightYears = 3}
            };

            foreach (var theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears);
            }
        }

        private static List<Element> BuildList()
        {
            return new List<Element>
            {
                new Element() {Symbol = "K", Name = "Potassium", AtomicNumber = 19},
                new Element() {Symbol = "Ca", Name = "Calcium", AtomicNumber = 20},
                new Element() {Symbol = "Sc", Name = "Scandium", AtomicNumber = 21},
                new Element() {Symbol = "Ti", Name = "Titanium", AtomicNumber = 22}
            };
        }
    }

    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }

    public class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }
}