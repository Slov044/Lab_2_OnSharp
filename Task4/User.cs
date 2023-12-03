namespace Task4;

public class User
{
    private readonly DateTime _registrationDate;
    private readonly int _age;
    private readonly string _firstName;
    private readonly string _lastName;
    private readonly string _login;

    public User(string login, string firstName, string lastName, int age)
    {
        _login = login;
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _registrationDate = DateTime.Now;
    }

    public void PrintUserInfo()
    {
        Console.WriteLine("Логін: " + _login);
        Console.WriteLine("Ім'я: " + _firstName);
        Console.WriteLine("Прізвище: " + _lastName);
        Console.WriteLine("Вік: " + _age);
        Console.WriteLine("Дата заповнення анкети: " + _registrationDate);
    }
}