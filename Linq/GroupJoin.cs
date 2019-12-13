namespace CSharp.Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
    }

    public class PetOwner
    {
        public string Name { get; set; }
        public List<string> Pets { get; set; }
    }

    public static class GroupJoin
    {

        static List<Employee> employeeList = new List<Employee>() {

            new Employee() { Id = 1, Name = "Madhav" },
            new Employee() { Id = 2, Name = "Arjun" },
            new Employee() { Id = 3, Name = "Test" }
        };

        static List<Address> addressList = new List<Address>() {
            new Address() { Id = 1, StreetName = "Street 1", City = "City 1", EmployeeId = 1},
            new Address() { Id= 2, StreetName ="Street 2", City = "City 2", EmployeeId = 1},
            new Address() { Id= 3, StreetName ="Street 3", City = "City 3", EmployeeId = 2}
        };

        static PetOwner[] petOwners =
        { new PetOwner { Name="Higa",
              Pets = new List<string>{ "Scruffy", "Sam" } },
          new PetOwner { Name="Ashkenazi",
              Pets = new List<string>{ "Walker", "Sugar" } },
          new PetOwner { Name="Price",
              Pets = new List<string>{ "Scratches", "Diesel" } },
          new PetOwner { Name="Hines",
              Pets = new List<string>{ "Dusty" } } };

        public static void Execute()
        {
            MethodSyntax();
            SelectMany();
            LeftJoin();
        }

        public static void MethodSyntax()
        {

            var result = employeeList.GroupJoin(addressList,
                                                emp => emp.Id,
                                                addr => addr.EmployeeId,
                                                (emp, addrList) => new { employee = emp, addrList = addrList });


            result.ToList().ForEach(x => { Console.WriteLine(x.employee.Name); Console.WriteLine(x.addrList.Count()); });

        }

        public static void SelectMany()
        {
            var result = petOwners.SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new {petOwner.Name, petName} );

            result.ToList().ForEach(x => {Console.WriteLine(x.Name); Console.WriteLine(x.petName);});
        }

        public static void LeftJoin() 
        {
            Console.WriteLine("Left Join");

            var result = employeeList.GroupJoin(addressList,
                                                emp => emp.Id,
                                                addr => addr.EmployeeId,
                                                (emp, addrList) => new { emp = emp, addressList = addrList })
                                     .SelectMany(empList => empList.addressList.DefaultIfEmpty(), (empAddr, addr) => new {empAddr.emp, addr?.City });

            result.ToList().ForEach(x => {Console.WriteLine(x.emp.Name); Console.WriteLine(x.City);});
        }
    }
}