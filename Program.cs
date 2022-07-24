using HomeWork_14.Models;


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
while (true)
{
    Char input = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (int.TryParse(input.ToString(), out int result) && result >= 1 && result <= 3)
    {
        var pageContent = phoneBook.
            OrderBy(p => p.Name).
            ThenBy(p => p.LastName).
            Skip((result - 1) * 2).
            Take(2);

        foreach (var item in pageContent)
            Console.WriteLine($"Контакт: {item.Name} {item.LastName}, тел:{item.PhoneNumber}, e-mail:{item.Email}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Записи не существует");
    }
}
