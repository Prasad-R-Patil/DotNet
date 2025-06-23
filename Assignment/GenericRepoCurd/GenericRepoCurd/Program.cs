namespace GenericRepoCurd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Person Eperson = new Employee() { EmpId=001,Name="Sagar",Age=24,Location= "Sangli" };


            Person Eperson1 = new Employee() { EmpId = 002, Name = "Zakanzulya", Age = 24, Location = "Pune" };

            Person Eperson2 = new Employee() { EmpId = 003, Name = "Yesha", Age = 24, Location = "Mumbai" };

            Person Eperson3 = new Employee() { EmpId = 004, Name = "Yogesh", Age = 24, Location = "Satara" };


            Person Ssupplier = new Supplier() { SupID = 001, Name = "Prasad", Age = 24, Location = "Buldhana" };
            Person Sshipper = new Shipper() { ShipId = 001, Name = "Tejas", Age = 24, Location = "Faltan" };
            ICommonRepository<Employee> Emp = new CommanRepository<Employee>();
            ICommonRepository<Supplier> Sup = new CommanRepository<Supplier>();
            ICommonRepository<Shipper> Ship = new CommanRepository<Shipper>();
            Emp.Insert((Employee)Eperson);
            Emp.Insert((Employee)Eperson1);
            Emp.Insert((Employee)Eperson2);
            Emp.Insert((Employee)Eperson3);
            Sup.Insert((Supplier)Ssupplier);
            Ship.Insert((Shipper)Sshipper);

            foreach (var person in Emp.GetAll())
            {
                Console.WriteLine($"Employee Id {person.EmpId} Name Is {person.Name} age is {person.Age} Location is {person.Location}");
                
            }

            foreach (var person in Sup.GetAll())
            {
                
                Console.WriteLine($"Supplier Id {person.SupID} Name Is {Ssupplier.Name} age is {Ssupplier.Age} Location is {Ssupplier.Location}");
            }

            foreach (var person in Ship.GetAll())
            {
                
                Console.WriteLine($"Shipper Id {person.ShipId} Name Is {Sshipper.Name} age is {Sshipper.Age} Location is {Sshipper.Location}");
                
            }

            Emp.Delete((Employee)Eperson3);

            Console.WriteLine("After Delete");



            foreach (var person in Emp.GetAll())
            {
                Console.WriteLine($"Employee Id {person.EmpId} Name Is {person.Name} age is {person.Age} Location is {person.Location}");

            }



        }
    }
}
