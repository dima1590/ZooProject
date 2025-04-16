namespace Zoo.Core.Abstractions.Interfaces
{
    public interface IAnimal
    {
        /// <summary>
        /// Издать звук
        /// </summary>
        void MakeSound();

        /// <summary>
        /// Покормить
        /// </summary>
        void Feed();

        /// <summary>
        /// Уложить спать
        /// </summary>
        void Sleep();

        /// <summary>
        /// Поиграть
        /// </summary>
        void Play();
    }
}