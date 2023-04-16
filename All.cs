/*************************       VARIABLE        *************************/
//string Name = "Bob"; //определение и инициализация переменной
//const string NAME = "Tom"; //создание константы, должна быть инициализирована при определении, после значение не может быть изменено

/*************************       LITERAL        *************************/
/*Литералы представляют неизменяемые значения (иногда их еще называют константами). Литералы можно передавать переменным в качестве значения.
Литералы бывают логическими, целочисленными, вещественными, символьными и строчными. И отдельный литерал представляет ключевое слово null.*/
//Literal.cs
//логические литералы
//Console.WriteLine(true);
//Console.WriteLine(false);
/*---   Целочисленные литералы    ---*/
//целые числа в десятичной форме используются как и в повседневной жизни
/*Console.WriteLine(-10);
Console.WriteLine(5);
//числа в двоичной форме предваряются символами 0b, после которых идет набор из нулей и единиц
Console.WriteLine(0b11);     // 3
Console.WriteLine(0b1011);   // 11
//числа в шестнадцатеричной форме применяются символы 0x, после которых идет набор символов от 0 до 9 и от A до F
Console.WriteLine(0x0A);     // 10
Console.WriteLine(0xFF);     // 255
*/

/*Console.WriteLine("Your name: ");
string? name = Console.ReadLine();
Console.WriteLine("You age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Name: {name}, age: {age}");*/

/*int a = 10;
int b = 2;
int c = a ---b;
Console.WriteLine(c);*/

/*************************       LOGIC OPERATION        *************************/
/*int x1 = 2; //010     &
int y1 = 5;//101
Console.WriteLine(x1 & y1); // выведет 0

int x2 = 4; //100
int y2 = 5; //101
Console.WriteLine(x2 & y2); // выведет 4*/

/*int x1 = 2; //010     |
int y1 = 5;//101
Console.WriteLine(x1|y1); // выведет 7 - 111
int x2 = 4; //100
int y2 = 5;//101
Console.WriteLine(x2 | y2); // выведет 5 - 101*/

/*int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101    ^
int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
int encrypt = x ^ key; //Результатом будет число 1001011 или 75
Console.WriteLine($"Зашифрованное число: {encrypt}") ; 
int decrypt = encrypt ^ key; // Результатом будет исходное число 45
Console.WriteLine($"Расшифрованное число: {decrypt}");*/

/*int x = 12;                 // 00001100       ~
Console.WriteLine(~x);      // 11110011   или -13*/

/*int num1 = 6;
int num2 = 10;
if(num1 < num2)
    Console.WriteLine($"{num1} меньше {num2}");
// -----------------------------     Ternar construction     -----------------------------
// int c = a > b ? a - b : a + b;
// int c = условие ? (если true) : (если false);
int num3 = num1 > num2 ? num1 + num2 : num2 - num1;
Console.WriteLine(num3);*/

/*int[] nums = {1, 2, 3, 4, 5};
Console.WriteLine(nums[^1]); //получение последнего элемента массива*/

/*int[,] mass1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine(mass1.GetUpperBound(0) + 1);  //2
Console.WriteLine(mass1.GetUpperBound(1) + 1);  //3
for (int i = 0; i < mass1.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mass1.Length/(mass1.GetUpperBound(0)+1); j++)
    {
        Console.Write($"{mass1[i, j]} \t");
    }
    Console.WriteLine();
}*/

// -----------------------------     Array invertion     -----------------------------
/*int[] numbers = { -4, -3, 2, 3, 1, -5 };
int n = numbers.Length;
int k = n / 2;
int temp = 0;
for (int i = 0; i < k; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[n-i-1];
    numbers[n-i-1] = temp;
}
foreach(int i in numbers)
    Console.WriteLine($"{i}\t");*/

// -----------------------------     Array sort     -----------------------------
/*int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
Console.WriteLine("sort array: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}*/

/*************************       METHODS        *************************/
/*SayHello();
SayHelloRu();
void SayHello()
{
    Console.WriteLine("Hello bro!");
}
void SayHelloRu() => Console.WriteLine("Привет"); //Сокращенная запись, если метод имеет только одну конструкцию*/

/*PrintMessage("Hello");
string ms = Console.ReadLine();
PrintMessage($"{ms}");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Sum(number1, number2);
void PrintMessage(string message)
{
    Console.WriteLine($"not - {message}");
}
void Sum(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");*/

/*string GetMessage()
{
    return "Hello";
}
Console.WriteLine(GetMessage());
string GetMessageRu() => "Привет";
Console.WriteLine(GetMessageRu());*/

// -----------------------------     REF     -----------------------------
/*void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");//6
}
int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");//5
Increment(ref number);
Console.WriteLine($"Число после метода Increment: {number}");//6*/

// -----------------------------     OUT     -----------------------------
/*void Sum(int x, int y, out int result) //out = return + ref
{
    result = x + y;
}
int number;
Sum(10, 15, out number);
Console.WriteLine(number);   // 25*/

/*oid GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
{
    rectArea = width * height;       // площадь прямоугольника
    rectPerimetr = (width + height) * 2; // периметр прямоугольника
}
int area;
int perimetr;
GetRectangleData(10, 20, out area, out perimetr);
Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60*/

// -----------------------------     PARAMS     -----------------------------
/*void Sum(int initialValue, params int[] mass) //после параметра с модификатором params мы НЕ можем указывать другие параметры.
{
    int result = initialValue;
    foreach (var n in mass)
        result += n;
    Console.WriteLine(result);
}
int[] nums = { 1, 2, 3, 4, 5, 6 };
Sum(10, nums);  // число 10 - передается параметру initialValue*/

// -----------------------------     Рекурсивная функция факториала     -----------------------------
// рекурсивная функция - функция, которая вызывает сама себя
/*int Factorial(int n)
{
    if (n == 1) return 1; // базовый вариант

    return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(4));*/

/*int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n; // базовый вариант

    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
Console.WriteLine(Fibonachi(7));*/

// -----------------------------     Static & function     -----------------------------
/*int Sum(int[] numbers)
{
    int result = 0;
    int limit = 0;
    foreach (int number in numbers)
        if (IsPassed(number, limit)) result += number;
    return result;
    static bool IsPassed(int number, int lim)   //IsPassed - локальная статическая функция; 
    //static - не дает функции обращаться к окружению, данная функция имеет доступ только к переменным number и lim
    {
        //return number > limit; // Ошибка: метод IsPassed не имеет доступа к переменной limit
        return number > lim;
    }
}
int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
int[] numbers2 = { 3, -4, 5, -6, 7 };
Console.WriteLine(Sum(numbers1));
Console.WriteLine(Sum(numbers2));*/

// -----------------------------     Switch & case     -----------------------------
/*string name = "Jack";
switch (name)
{
    case "Bob":
        Console.WriteLine("Ваше имя - Bob");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя - Tom");
        break;
    case "Sam":
        Console.WriteLine("Ваше имя - Sam");
        break;
    case "Jack":
        Console.WriteLine("Ohh, Jack");
        goto default;
    default:
        Console.WriteLine("Неизвестное имя");
        break;
}*/

/*int DoOperation(char op, int a, int b)
{
    switch (op)
    {
        case '+': return a + b;
        case '-': return a - b;
        case '*': return a * b;
        case '/': return a / b; 
        default: return 0;
    }
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
char operation = Convert.ToChar(Console.ReadLine());
Console.WriteLine(DoOperation(operation, a, b));*/

/*int DoOperation(char op, int a, int b) => op switch{      //Сокращенная версия switch
    '+' => a + b,
    '-' => a - b,
    '*' => a * b,
    '/' => a / b,
    _ => 0
};
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
char operation = Convert.ToChar(Console.ReadLine());
Console.WriteLine(DoOperation(operation, a, b));*/

// -----------------------------     Перечисления enum     -----------------------------
/*DayTime now = DayTime.Morning;
PrintMessage(now);                   // Добрый вечер
PrintMessage(DayTime.Afternoon);    // Добрый день
PrintMessage(DayTime.Night);        // Доброй ночи
void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;
    }
}
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}*/

/*DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Subtract);     // 5
DoOperation(10, 5, Operation.Multiply);     // 50
DoOperation(10, 5, Operation.Divide);       // 2
void DoOperation(double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
}
enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}*/



