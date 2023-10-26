namespace limitation
{

    class Program
    {
        static void Main()
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine("Максимальное число: " + intStack.Max());

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Сок");
            stringStack.Push("Авокадо");
            stringStack.Push("Москва");
            Console.WriteLine("Последняя (максимальная) строка: " + stringStack.Max());
            Pair<string, string> pair = new Pair<string, string>("Привет", "Пока");

            Console.WriteLine("\nДо свапа:");
            Console.WriteLine("Первый эл.: " + pair.First);
            Console.WriteLine("Второй эл.: " + pair.Second);

            pair.Swap();

            Console.WriteLine("\nПосле свапа:");
            Console.WriteLine("Первый эл.: " + pair.First);
            Console.WriteLine("Второй эл.: " + pair.Second);

            int sumInt = Calculator<int>.Add(5, 1);
            Console.WriteLine("\nСумма интов: " + sumInt);

            double sumDouble = Calculator<double>.Add(3.5, 2.7);
            Console.WriteLine("Сумма даблов: " + sumDouble);

            string sumString = Calculator<string>.Add("Как ", "дела?");
            Console.WriteLine("Конкантинация стрингов: " + sumString);
        }
    }
}
