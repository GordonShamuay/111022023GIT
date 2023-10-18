// Задание №2 Привет Юзер. Для начала запросим его имя
// Console.WriteLine("Как тебя зовут? Напиши своё имя и нажми клавишу ВВОД ");
//string UserName = Console.ReadLine();
// Console.WriteLine("Привет, ");
// Console.WriteLine(UserName);
//------------
// Новый оператор Write. Перевод курсора не осуществляется на новую строку,
// работа программы продолжается в текущей строке.
//------------
Console.Write("Как тебя зовут? Напиши своё имя и нажми клавишу ВВОД ");
string UserName = Console.ReadLine();
//Курсор будет стоять в конце строки после слова ВВОД и ждять.
Console.Write("Привет, ");
Console.Write(UserName); 
