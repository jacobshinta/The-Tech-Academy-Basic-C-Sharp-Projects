using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            employees.Add(new Employees() { first = "Joe", last = "Mama", Id = 1 });
            employees.Add(new Employees() { first = "Rachel", last = "Ray", Id = 2 });
            employees.Add(new Employees() { first = "Billy", last = "Billington", Id = 3 });
            employees.Add(new Employees() { first = "Joe", last = "Dirt", Id = 4 });
            employees.Add(new Employees() { first = "Susan", last = "Smith", Id = 5 });
            employees.Add(new Employees() { first = "Frank", last = "Ocean", Id = 6 });
            employees.Add(new Employees() { first = "Kaylee", last = "Joel", Id = 7 });
            employees.Add(new Employees() { first = "Woody", last = "Allen", Id = 8 });
            employees.Add(new Employees() { first = "Stevie", last = "Nicks", Id = 9 });
            employees.Add(new Employees() { first = "Jennfer", last = "Lopez", Id = 10 });

            foreach (Employees x in employees)
            {
                if (x.first == "Joe")
                {
                    Console.WriteLine(x.first + " " + x.last + " " + x.Id);
                }
            }
            Console.ReadLine();

            List<Employees> lambda = employees.Where(a => a.first == "Joe").ToList();
            foreach (Employees x in lambda)
            {
                Console.WriteLine(x.first + " " + x.last + " " + x.Id);
            }

            Console.ReadLine();

            List<Employees> lambdaId = employees.Where(a => a.Id > 5).ToList();
            foreach (Employees x in lambdaId)
            {
                Console.WriteLine(x.first + " " + x.last + " " + x.Id);
            }

            Console.ReadLine();
        }

    }
}
