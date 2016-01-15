using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void DoWork()
        {
            Tree<Employee> empTree = new Tree<Employee>(new Employee
            { Id = 1, FirstName = "Janet", LastName = "Gates", Deparment = "IT" });

            empTree.Insert(new Employee{ Id = 2, FirstName = "Orlando", LastName = "Gee",
            Deparment = "Maketing"});

            empTree.Insert(new Employee
                { Id = 4, FirstName = "Keith", LastName = "Harrington", Deparment = "IT"});

            empTree.Insert(new Employee
            { Id = 3, FirstName = "Eric", LastName = "Lang", Deparment = "Sales" });

            empTree.Insert(new Employee
            { Id = 5, FirstName = "David", LastName = "Liu", Deparment = "Maketing"});

            Console.WriteLine("All employees");
            var allEmployees = from e in empTree.ToList<Employee>() select e;

            foreach(var emp in allEmployees)
            {
                Console.WriteLine(emp);
            }

            empTree.Insert(new Employee { Id = 7, FirstName = "Donald", LastName = "Blanton", Deparment = "IT" });
            Console.WriteLine("\nEmployee added");

            Console.WriteLine("All employees");
            foreach(var emp in allEmployees)
            {
                Console.WriteLine(emp);
            }

           /* Console.WriteLine("List of deparments: ");

            //var  depts = empTree.Select(d => d.Deparment).Distinct();
            var depts = (from d in empTree select d.Deparment).Distinct();
            foreach(var dept in depts)
            {
                Console.WriteLine("Deparment: {0}", dept);
            }

            Console.WriteLine("\nEmployees in the IT deparment");
            // var iTEmployees = empTree.Where(e => String.Equals(e.Deparment, "IT")).Select(emp => emp);
            var iTEmployees = from e in empTree where String.Equals(e.Deparment, "IT") select e;

            foreach(var emp in iTEmployees)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("\nAll employees grouped by deparment");
            // var employeesByDept = empTree.GroupBy(e => e.Deparment);
            var employeesByDept = from e in empTree group e by e.Deparment;

            foreach(var dept in employeesByDept)
            {
                Console.WriteLine("Deparment: {0}", dept.Key);
                foreach(var emp in dept)
                {
                    Console.WriteLine("\t{0} {1}", emp.FirstName, emp.LastName);
                }
            }
           */
        }

        static void Main()
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
