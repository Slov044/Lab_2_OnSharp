using System.Text;
using Task1;

Console.InputEncoding = Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Task1");
var address = new Address
{
    Index = 12345,
    Country = "Україна",
    City = "Київ",
    Street = "Вулиця Кошиця",
    House = "12",
    Apartment = "34"
};

Console.WriteLine("Індекс: " + address.Index);
Console.WriteLine("Країна: " + address.Country);
Console.WriteLine("Місто: " + address.City);
Console.WriteLine("Вулиця: " + address.Street);
Console.WriteLine("Будинок: " + address.House);
Console.WriteLine("Квартира: " + address.Apartment);