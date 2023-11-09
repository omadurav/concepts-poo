using ConceptsPOO;

Employee employee1 = new SalaryEmployee()
{
    Id = 1011,
    BirthDate = new Date(1995, 10, 10),
    FirstName = "Maria",
    LastName = "Contreras",
    HiringDate = new Date(2015, 02, 10),
    IsActive = true,
    Salary = 1300000M
};

Employee employee2 = new HourlyEmployee()
{
    Id = 3225,
    BirthDate = new Date(1989, 04, 19),
    FirstName = "Juan",
    LastName = "Valdes",
    HiringDate = new Date(2010, 10, 02),
    IsActive = true,
    Hours = 50,
    HourValue = 10400M
};

Employee employee3 = new ComissionEmployee()
{
    Id = 3225,
    BirthDate = new Date(1989, 04, 19),
    FirstName = "Lina",
    LastName = "Marulanda",
    HiringDate = new Date(2020, 01, 30),
    IsActive = true,
    ComissionPercentaje = 0.10F,
    Sales = 32000000M
};

Employee employe4 = new BaseCommisionEmployee()
{
    Id = 3225,
    BirthDate = new Date(1989, 04, 19),
    FirstName = "Carlos",
    LastName = "Niño",
    HiringDate = new Date(2011, 06, 24),
    IsActive = true,
    ComissionPercentaje = 0.03F,
    Sales = 2000000M,
    Base = 850000M
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employe4
};

decimal paysheet = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine($"{employee}\n");
    paysheet += employee.GetValueToPay();
}

Console.WriteLine("                                 ===============");
Console.WriteLine($"Total Paysheet:               {$"{paysheet:C2}",18}");

Console.WriteLine("=========================================");

Invoice invoice = new Invoice()
{
    Id = 1,
    Description = "Xbox One",
    Price = 1400000M,
    Quantity = 1
};

Console.WriteLine(invoice);




