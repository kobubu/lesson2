using System;
using System.Security.Cryptography.X509Certificates;

namespace task4
{
    class task4
    {


        //создаем перечисление для выбора места в театре
        
        static void Main(string[] args)
        {
            //я не понял смысл задания, но в нем сказано, что должна быть заранее заготовленная перменная, создадим заранее заготовленных перменных (цена, серия, ряд, место ) 
            int price = 1000;
            char serie = 'A';
            int number = 151515;
            byte row = 5;
            byte seat = 34;
            
            string name = "Бальзак. Тридцатилетняя женщина";

            Console.WriteLine("Выберите часть зала, где вы хотите сидеть\n" +
                "партер\n" +
                "бельэтаж\n" +
                "ложа\n");
            string zone = Console.ReadLine();

            
            //вывод билета 
            Console.WriteLine("\n"+
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                    "Управление по культуре Российской Федерации\n\n" +
                   $"серия {serie} номер №{number}              \n\n" +
                   $"                   {zone}                  \n\n" +
                   $"                     ряд:{row} место:{seat}\n\n" +
                   $"{name}              \n" +
                   $"    билет куплен {DateTime.Now.ToShortTimeString()}\n" +
                   $"           {DateTime.Now.ToShortDateString()}   \n" +
                   $"Цена: {price} рублей                        \n\n" +
                   $"      Московский театр классического цирка \n\n" +
                   "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n"+
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            
            // Завершение программы по клавише
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();


        }
    }
        



    


        
}

