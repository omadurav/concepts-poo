using ConceptsPOO;

Console.WriteLine("POO Fundamentals");
Console.WriteLine("================");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
