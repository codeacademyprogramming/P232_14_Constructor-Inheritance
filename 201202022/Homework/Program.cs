using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notebook notebook1 = new Notebook()
            {
                Name = "Rog strix",
                BrandName = "Asus",
                Price = 2600

            };

            Notebook notebook2 = new Notebook()
            {
                Name = "MacBookpro",
                BrandName = "Apple",
                Price = 2900

            };

            Notebook notebook3 = new Notebook()
            {
                Name = "Lenovo",
                BrandName = "GamePad",
                Price = 3900

            };

            Notebook notebook4 = new Notebook()
            {
                Name = "HP",
                BrandName = "345S",
                Price = 900

            };

            Notebook notebook5 = new Notebook()
            {
                Name = "Asus",
                BrandName = "TUF",
                Price = 2900

            };

            Notebook[] notebooks = new Notebook[5] {notebook1,notebook2,notebook3,notebook4,notebook5};

            Console.WriteLine("MinPrice:");
            string minPriceStr = Console.ReadLine();
            double minPrice = Convert.ToDouble(minPriceStr);//double.Parse(minPriceStr)

            Console.WriteLine("MaxPrice:");
            string maxPriceStr = Console.ReadLine();
            double maxPrice = Convert.ToDouble(maxPriceStr);


            var filteredNotebooks = FilterByPrice(minPrice, maxPrice, notebooks);

            if (filteredNotebooks.Length == 0)
            {
                Console.WriteLine("Axtardiginiz deyerde data yoxdur!");
            }
            else
            {
                for (int i = 0; i < filteredNotebooks.Length; i++)
                {
                    Console.WriteLine(filteredNotebooks[i].GetInfo());
                }
            }
            Car car1 = new Car
            {
                Brand = "Lexus",
                Model = "Lx570",
                CurrentFuel = 60,
                FuelFor1Km = 3,
                Millage = 4235,
            };
            Console.WriteLine("Getmek istediyiniz mesafeni daxil edin");
            string kmStr=Console.ReadLine();
            int km= Convert.ToInt32(kmStr);
            car1.Drive(km);
            Console.WriteLine(car1.CurrentFuel);
            
        }

        static Notebook[] FilterByPrice(double min,double max,Notebook[] arr)
        {
            int count = 0;

            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i].Price >= min && arr[i].Price <= max)
                {
                    count++;
                }
            }

            Notebook[] filteredArr = new Notebook[count];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price >= min && arr[i].Price <= max)
                {
                    filteredArr[j] = arr[i];
                    j++;
                }
            }

            return filteredArr;
        }
    }
}
