namespace CSharp.Linq {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Select {

        public class Employee {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        static List<Employee> employeeList = new List<Employee>() {

            new Employee() { Id = 1, Name = "Ram" },
            new Employee() { Id = 2, Name = "Arjun" }
        };

        public static void SimpleSelect() {
            var data = employeeList.Select(emp => emp.Id).ToList();
            data.ForEach(x => Console.WriteLine(x));
        }
    }
}