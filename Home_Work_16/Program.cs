using System;

namespace Home_Work_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Type firstType = Type.GetType("System.Console");

            Console.WriteLine("Методы System.Console - ");
            foreach (var method in firstType.GetMethods())
            {
                Console.WriteLine(method.Name);
            }

            Phone phone = new Phone()
            {
                Model = "A5",
                Brand = "Samsung",
                Color = "Pink",
                Cost = 75000
            };




            Console.WriteLine("Свойства класса - Phone: ");

            Type secondType = phone.GetType();



            foreach (var properties in secondType.GetProperties())
            {
                Console.WriteLine($"{properties.Name} - {properties.GetValue(phone, null)}");
            }

            Console.ReadKey();
        }
    }
}
