//void SayHello(){
//    Console.WriteLine("Hello");
//}
//SayHello();
//void SayHello2() => Console.WriteLine("Hello");
//Console.Write("Введите ваше имя: ");
//string name = Console.ReadLine();
//Console.Write("Введите ваш язык: ");
//string language  = Console.ReadLine().ToLower();
//void SayHelloru() => Console.WriteLine($"Привет, {name}!");
//void SayHelloen() => Console.WriteLine($"Hello, {name}!");
//void SayHellode() => Console.WriteLine($"Guten Tag, {name}!");
//switch (language)
//{
//    case "английский": SayHelloen(); break;
//    case "русский": SayHelloru(); break;
//    case "немецкий": SayHellode(); break;
//    default: Console.WriteLine("Язык не найден"); break;
//}
//void Game()
//{
//    string myGame = "GTA V";
//    Console.WriteLine(myGame);
//}
//Game();

//void Print(string message)
//{
//    Console.WriteLine(message);
//}
//Print("Привет");
//Console.WriteLine("Как тебя зовут?");
//Console.WriteLine("Введите своё имя: ");
//string name1 = Console.ReadLine();
//Print($"Твоё имя: {name1}");
//void Sum(int x, int y)
//{
//    int result = x + y;
//    Console.WriteLine(result);
//}
//Sum(12, 12);
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//Sum(x, y);
//void PrintPerson(string personName = "None", int age = 18,string vuz = "None")
//{
//    Console.WriteLine($"Имя: {personName}, возраст: {age}, вуз: {vuz}");
//}
//PrintPerson("Nastya", 20,"VF Volgu");
//PrintPerson(vuz:"VF Volgu", age:20,personName:"Nastya");
//PrintPerson();
//string GetMessage()
//{
//    return "Hello";
//}
//int GetNumbrr() => 10;
//var result = GetNumbrr();
//Console.WriteLine(GetMessage());
//Console.WriteLine(result);
//int Sum(int a, int b)
//{
//    return a + b;
//}
//Sum(10, 20);
////Console.WriteLine(Sum(34,35));
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//void CheckValue(int number)
//{
//    if (number < 0)
//    {
//        Console.WriteLine("Otric");
//        return;
//    }
//    Console.WriteLine("Poloshit");
//}
//CheckValue(number);
//Random random = new Random();
//int number = random.Next(0,100);
//Console.WriteLine(number);
//void ShowWelcome() => Console.WriteLine("Здравствуйте");
//void ShowBye() => Console.WriteLine("Пока");
//string GetWeather()
//{
//    string[] weather = ["Sunny", "Cloudy", "Rainy", "Snowy", "Groza"];
//    Random random = new Random();
//    int index = random.Next(weather.Length);
//    return weather[index];
//}
//ShowWelcome();
//string weat = GetWeather();
//Console.WriteLine(weat);
//ShowBye();
int Factorial(int n)
{
    if (n == 1) return 1;
    return n*Factorial(n-1);
}
Console.WriteLine(Factorial(5));
