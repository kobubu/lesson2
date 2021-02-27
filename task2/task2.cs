using System;

namespace task2
{
    class task2
    {
        static void Main(string[] args)
        {

            //просим пользователя ввести порядковый номер месяца
            Console.WriteLine("Введите порядковый номер месяца");
            
            // cоздаем переменную monthnumber для записи введенного значения
            string monthNumber = Console.ReadLine();

            //создаем переменную типа int, в которую будут преобразованы данные, введенные пользователем
            int monthNumberConverted;
                     
            //преобназуем строковую переменную, введеную пользователм, в целочисленную
            int.TryParse(monthNumber, out monthNumberConverted);

            // если пользователь ввел значение меньше 1 и больше 12, то повтор ввода значения 
            while (monthNumberConverted > 12 || monthNumberConverted < 1)
            
            {
                Console.WriteLine("Вы ввели некорректное значение\n" +
                    "введите значение от 1 до 12");
                monthNumber = Console.ReadLine();
                int.TryParse(monthNumber, out monthNumberConverted);
            }



             //cоздаем перменную для записи даты произвольного форматирования
             DateTime userdate = new DateTime(2021, monthNumberConverted, 26);

            //преобразуем формат переменной для вывода только месяца
             userdate.ToString("MMMM");

            //выводим на консоль месяц
            Console.WriteLine("Вы ввели " + userdate.ToString("MMMM") + ".");
           
            //просим пользователя ввести любую клавишу для завершения программы
            Console.WriteLine("Нажмите любую клавишу для завершения программы");
            Console.ReadKey();
            
        }
        
    }
}
