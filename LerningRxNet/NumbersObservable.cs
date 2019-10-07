using System;
using System.Reactive.Disposables;

namespace LerningRxNet
{
    /// <summary>
    /// ИЗДАТЕЛЬ -- метод который имитит поток сообщений
    /// </summary>
    public class NumbersObservable : IObservable<int>
    {
        // Количество сообщений
        private readonly int _amount;

        public NumbersObservable(int amount)
        {
            _amount = amount;
        }

        /// <summary>
        /// Обработчик подписки
        /// </summary>
        /// <param name="observer">Подписчик</param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<int> observer)
        {
            // Отправляем подписчику поток из _amount сообщений
            for (int i = 0; i < _amount; i++)
            {
                observer.OnNext(i);
            }
            // Указываем что Издатель закончил свою работу
            observer.OnCompleted();
            // Высвобождаем ресурсы
            return Disposable.Empty;
        }
    }
}