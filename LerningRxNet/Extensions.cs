using System;

namespace LerningRxNet
{
    /// <summary>
    /// Класс содержащий расширяющие методы
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Подписка на IObservable
        /// </summary>
        /// <typeparam name="T">Тип посылаемых сообщений</typeparam>
        /// <param name="observable">Издатель</param>
        /// <param name="name">Имя подписчика</param>
        /// <returns></returns>
        public static IDisposable SubscribeConsole<T>(
            this IObservable<T> observable, string name = "")
        {
            return observable.Subscribe(new ConsoleObserver<T>(name));
        }
    }
}