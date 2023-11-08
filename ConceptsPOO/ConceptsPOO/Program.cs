using ConceptsPOO;

Employee employee = new HourlyEmployee()
{
    Id = 1,
    BirthDate = new Date(1989, 04, 19),
    FirstName = "Juan",
    LastName = "Valdes",
    HiringDate = new Date(2010, 10, 02),
    IsActive = true,
    Hours = 50,
    HourValue = 10400
};

Console.Write(employee);
