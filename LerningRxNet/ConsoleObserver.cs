using System;
using System.Reactive;

namespace LerningRxNet
{
    /// <summary>
    /// Подписчик
    /// </summary>
    /// <typeparam name="T">Тип сообщения</typeparam>
    public class ConsoleObserver<T> : IObserver<T>
    {
        // Имя подписчика
        private readonly string _name;

        public ConsoleObserver(string name = "")
        {
            _name = name;
        }

        // Обработка события окончания сообщений от Издателя
        public void OnCompleted() => Console.WriteLine($"{_name} - OnCompleted()");

        // Обработка ошибок Издателя
        public void OnError(Exception error)
        {
            Console.WriteLine($"{_name} - OnError()");
            Console.WriteLine($"\t {error}");
        }

        // Обработка очередного сообщения от издателя
        public void OnNext(T value) => Console.WriteLine($"{_name} OnNext({value})");
    }
}