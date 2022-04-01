using System;
using PersonDate;
class Program
{
   public static void Main ()
    {
   
        string initialized;

        Console.WriteLine($"Здравствуйте, вы пришли на подбор автомобиля мечты. " +
            "Если вы готовы продолжить, отправьте согласие словом \"Да\"");
        initialized = Console.ReadLine();

        if (initialized.ToLower() == "да" || initialized.ToLower() == "yes")
        {
            Person date = new Person();
            date.Print();
        }
        else
        {
            Console.WriteLine("Приходите снова будем рады помочь");
        }
    }
}
