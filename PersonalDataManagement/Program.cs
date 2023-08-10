namespace PersonalDataManagement;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Data management system: ");
        List<Person> persons = new List<Person>();
        persons.Add(new Person()
        {
            SSN = 1,
            Name = "a",
            Address = "a",
            Age = 14,
        });
        persons.Add(new Person()
        {
            SSN = 2,
            Name = "b",
            Address = "b",
            Age = 16,
        });
        persons.Add(new Person()
        {
            SSN = 3,
            Name = "c",
            Address = "c",
            Age = 18,
        });
        persons.Add(new Person()
        {
            SSN = 4,
            Name = "d",
            Address = "d",
            Age = 20,
        });
        persons.Add(new Person()
        {
            SSN = 5,
            Name = "e",
            Address = "e",
            Age = 22,
        });
        persons.Add(new Person()
        {
            SSN = 6,
            Name = "f",
            Address = "f",
            Age = 24,
        });
        persons.Add(new Person()
        {
            SSN = 7,
            Name = "e",
            Address = "e",
            Age = 26,
        });
        persons.Add(new Person()
        {
            SSN = 8,
            Name = "f",
            Address = "f",
            Age = 28,
        });
        persons.Add(new Person()
        {
            SSN = 9,
            Name = "g",
            Address = "g",
            Age = 30,
        });
        persons.Add(new Person()
        {
            SSN = 10,
            Name = "h",
            Address = "h",
            Age = 32,
        });
        Operation operation = new Operation();
        operation.RetreiveAverageAge(persons);
    }
}
