namespace CSharp.Linq {
    
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Join {

        // Correlates the elements of two sequences based on matching keys.

        public class Employee {
            public int Id { get; set; }
            public string Name { get; set; }
            public int AddressId {get; set;}
            public int AccountId {get; set;}
        }

        public class Address {
            public int Id { get; set; }
            public string StreetName {get; set;}
            public string City { get; set; }
        }

         public class Account {
            public int Id { get; set; }
            public string BankName {get; set;}
            public string AccountNo { get; set; }
        }

        static List<Employee> employeeList = new List<Employee>() {

            new Employee() { Id = 1, Name = "Madhav", AddressId = 1, AccountId = 1 },
            new Employee() { Id = 2, Name = "Arjun", AddressId = 2, AccountId = 2 }
        };

        static List<Address> addressList = new List<Address>() {
            new Address() { Id = 1, StreetName = "Street 1", City = "City 1"},
            new Address() { Id= 2, StreetName ="Street 2", City = "City 2"}
        };

         static List<Account> accountList = new List<Account>() {
            new Account() { Id = 1, BankName = "HDFC", AccountNo = "123456790"},
            new Account() { Id= 2, BankName ="SBI", AccountNo = "0987654321"}
        };

        public static void Execute() {
            MethodSyntax();
            SelectAfterJoin();
            MultipleJoin();
        }

        public static void MethodSyntax() {
            var data = employeeList.Join( addressList, 
                                          emp => emp.AddressId, add => add.Id, 
                                          (emp, add) => new {emp, add})
                                    .ToList();

            data.ForEach(x => Console.WriteLine(x.emp.Name));
        }

        public static void SelectAfterJoin() {

            Console.WriteLine("Select After Join");

            var data = employeeList.Join( addressList, 
                                          emp => emp.AddressId, add => add.Id, 
                                          (emp, add) => new {emp, add})
                                    .Select(x => new {name = x.emp.Name, Address = x.add.City})
                                    .ToList();
            
            data.ForEach(x => Console.WriteLine(x));

        }

        public static void MultipleJoin() {
             Console.WriteLine("Multiple Join");

             var data = employeeList.Join( addressList, 
                                          emp => emp.AddressId, 
                                          add => add.Id, 
                                          (emp, add) => new {emp, add})
                                    .Join( accountList,
                                            emp => emp.emp.AccountId,
                                            acc => acc.Id,
                                            (emp, acc) => new {emp, acc})
                                    .Select(x => new { x.emp.emp.Name, x.acc.BankName})
                                    .ToList();

            data.ForEach(x => Console.WriteLine(x));
        }
    }
}