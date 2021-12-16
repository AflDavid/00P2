using System;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultate UEO = new Facultate("UEO");
            UEO.Students = new Student[] {new Student("Afloarei", "David", new DateTime(2001, 08, 21), "112233"),
                              new Student("Andrei", "Daniel", new DateTime(2002, 01, 02), "543210"),
                              new Student("Ulici", "Raul", new DateTime(2002, 01, 03), "012345")};


            Console.WriteLine(UEO.Index("112233"));


        }
    }
}

