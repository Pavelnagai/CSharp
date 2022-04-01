using System;
using Car;

namespace PersonDate{
    class Person
    {
        CarSelection car = new CarSelection();
        public string name = "Undifiend";
        public int age;


        public void Print()
        {
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя: {name}, Возраст: {age}");
            if (age >= 18)
            { 
                car.Car();
            }
            else
            {
                Console.WriteLine("К сожалению, мы вам не можем ничем помочь." +
                    " По достижению 18 лет мы будем рады видеть вас снова!");
            }
        }
     
    }
}

