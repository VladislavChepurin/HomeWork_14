using HomeWork_14.Models;

namespace HomeWork_14;
class Program
{
    static void Main(string[] args)
    {
        //  создаём пустой список с типом данных Contact
        // Исправим инициализацию списка
        var phoneBook = new List<Contact>
        {
            new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
            new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
            new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
            new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
            new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
            new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
        };

        int i = default;
        var sortedPhoneBook = phoneBook.OrderBy(p => p.Name).ThenBy(p => p.LastName);
        foreach (var item in sortedPhoneBook)
        {
            i++;
            Console.WriteLine($"№ {i}: {item.Name} {item.LastName}, тел:{item.PhoneNumber}, e-mail:{item.Email}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}