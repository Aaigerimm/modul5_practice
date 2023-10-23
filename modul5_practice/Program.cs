using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_practice
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }

    class Program
    {
        // Метод, который генерирует пользовательское исключение
        static void GenerateException()
        {
            Console.WriteLine("Генерация пользовательского исключения...");
            throw new CustomException("Пример пользовательского исключения");
        }

        // Метод, который вызывает GenerateException и перехватывает исключение
        static void CallerMethod()
        {
            try
            {
                GenerateException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Исключение было перехвачено в CallerMethod: " + ex.Message);
                // Поднятие исключения в вызывающий метод
                throw;
            }
        }

        static void Main()
        {
            try
            {
                CallerMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Исключение было перехвачено в Main: " + ex.Message);
                Console.ReadKey();
            }
        }
    }

}
