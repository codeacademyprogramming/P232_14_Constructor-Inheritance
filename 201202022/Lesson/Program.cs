using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Human("Nermin");

            Console.WriteLine(human1.Name);
            Console.WriteLine(human1.Surname);
            Console.WriteLine(human1.Age);

            var human2 = new Human("Abbas","Hikmetov");



            Student std1 = new Student("Tofiq")
            {
                Surname = "Hikmetov",
                Age = 30,
                AvgPoint = 55,
                GroupNo = "P111"
            };

            std1.Age = 45;


            var tch1 = new Teacher("Abbas", "Hikmetov", "Programming");
            tch1.Age = 55;


            WarrantyStudent ws1 = new WarrantyStudent("Abbas", "Hikmetov", "P110");


            Car car1 = new Car(80);

            car1.Brand = "Mercedes";
            car1.Model = "E200";
            car1.Year = 2015;

            Train tr1 = new Train();

            tr1.Brand = "Kur";
            tr1.Model = "T-100";
            tr1.VaqonCount = 45;
            tr1.Year = 2008;

            HybridCar hybrid1 = new HybridCar(50);
            ElectroCar electro1 = new ElectroCar();


            Console.WriteLine("Axtaris etmek isteyirsinizmi? y/n");

            string ans = Console.ReadLine();

            if (ans == "y")
            {
                Console.WriteLine("Axtaris deyerini yaz");
            }
            else
            {
                Console.WriteLine("bitdi");
            }
            
        }
    }
}
