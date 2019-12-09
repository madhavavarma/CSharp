namespace CSharp.Linq {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Select {

        // Projects each element of a sequence into a new form by incorporating the element's index

        public class Employee {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        static List<Employee> employeeList = new List<Employee>() {

            new Employee() { Id = 1, Name = "Madhav" },
            new Employee() { Id = 2, Name = "Arjun" }
        };

        public static void Execute() {
            MethodSyntax();
            QuerySyntax();
            Index();
            IndexQuerySyntax();
        }

        public static void MethodSyntax() {

            Console.WriteLine("SelectMethodSyntax");

            var data = employeeList.Select(emp => emp.Id).ToList();
            data.ForEach(x => Console.WriteLine(x));
        }

        public static void QuerySyntax() {

            Console.WriteLine("SelectQuerySyntax");

            var data = (from emp in employeeList
                       select emp.Id).ToList();

            data.ForEach(x => Console.WriteLine(x));
        }

        public static void Index() {
            Console.WriteLine("Index");

            var data = employeeList.Select((emp, index) => new {emp.Id, index});

            data.ToList().ForEach(x => Console.WriteLine(x));
        }

        public static void IndexQuerySyntax() {
            Console.WriteLine("IndexQuerySyntax");

            var data = from emp in employeeList.Select((emp, index) => new {emp.Id, index})
                        select emp;

            data.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}