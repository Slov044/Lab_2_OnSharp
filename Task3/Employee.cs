namespace Task3;

internal class Employee
{
    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public string LastName { get; }

    public string FirstName { get; }

    public void CalculateSalary(string position, int experience)
    {
    }
}