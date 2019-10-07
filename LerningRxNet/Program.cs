using System;

namespace LerningRxNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициируем Издаделя
            var numbers = new NumbersObservable(5);
            // Создаем Подписчика
            //var subscription = numbers.Subscribe(new ConsoleObserver<int>("numbers"));
            
            // Или с помощью нашего расширяющиего метода
            var subscription = numbers.SubscribeConsole("newNumbers");
        }
    }
}
