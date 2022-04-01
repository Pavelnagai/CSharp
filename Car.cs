using System;
using PersonDate;

namespace Car
{
    public class CarSelection
    {
        public void Car()
        {
            string[] carAmerica = { "Ford", "Dodge" };
            string[] carEuropa = { "Audi", "Mersedec" };
            string[] carRussia = { "Lada"};

            Console.WriteLine("Введите цифрой, какой автопром вам нравится? " +
                "1. Русский, 2. Европейский, 3. США");
            int avto =Convert.ToInt32(Console.ReadLine());

            switch (avto)
            {
                case 1:
                    {
                        Car_Standart(carRussia);
                        break; 
                    }
                case 2:
                    {
                        Car_Standart(carEuropa);
                        break;
                    }
                case 3:
                    {
                        Car_Standart(carAmerica);
                        break;
                    }
                default:
                        return;
                   
            }
        }
        public void Car_Standart(string[] country)
        {
            Person date = new Person();
            int num = 1;
            foreach (string i in country)
            { 
                Console.WriteLine($"{num}.{i}");
                num++;
            }
            Console.WriteLine("Выберите автомобиль под цифрой");
            int index = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Поздравляю, вы выбрали себе автомобиль {country[index - 1]}.");
            Console.WriteLine("Мы рады были помочь приходите еще");
        } 
    }
}
