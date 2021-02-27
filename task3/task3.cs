using System;

namespace task3
{
    class task3
    {
        static void Main(string[] args)
        {
                        
            //просим пользователя число
            Console.WriteLine("Введите число");
            
            //создаем переменную для введенного значения
            string inputNumber = Console.ReadLine();

            //создаем переменную для преобразования введенного значения в целочисленный тип
            int outputNumber;

            //создаем булевскую переменную со значением true, если преобразование в целочисленный тип пройдет успешно
            bool convertionSuccess = int.TryParse(inputNumber, out outputNumber);

            // проверяем, прошло ли преобразование в целочисленный тип
            if (convertionSuccess)
            {
                if (outputNumber % 2 == 0) // проверка доп условаия (остаток от деления числа на 2 = 0
                {
                    Console.WriteLine("Вы ввели четное число");
                }
                else
                {
                    Console.WriteLine("Вы ввели нечетное число"); //если есть остаток, то пишем, что число не целое 

                }

            }
            else
            {
                Console.WriteLine("Извольте ввести целое число"); //если конверсия в целое число не удалась, то написать, чтобы ввели целое
            }
            

            // Завершение программы по клавише
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
