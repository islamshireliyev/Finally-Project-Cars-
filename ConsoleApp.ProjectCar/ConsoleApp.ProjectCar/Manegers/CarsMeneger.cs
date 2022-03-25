using ConsoleApp.ProjectCar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Manegers
{
    internal class CarsMeneger
    {
        Cars[] data=new Cars[0];
        public void Add(Cars entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }
        public void EditCarModel(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Masinun modelini secin...");
                    int newModel = ScanerMeneger.ReadInteger("Modelin Id-sini daxil edin: ");
                    data[i].ModelsId = newModel;
                    break;
                }
            }
        }
        public void EditYear(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Masinin buraxilis ilini deyisirsiniz...");
                    DateTime newYear = ScanerMeneger.ReadDate("Buraxilis  ilini daxil edin: ");
                    data[i].GraduationYear = newYear;
                    break;
                }
            }
        }
        public void EditPrice(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Masinin Qiymetini deyisirsiniz...");
                    double newPrice = ScanerMeneger.ReadDouble("Yeni qiymeti daxil edin: ");
                    data[i].Price = newPrice;
                    break;
                }
            }
        }
        public void EditColor(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Masinin rengini deyisirsiniz...");
                    string newColor = ScanerMeneger.ReadString("Yeni rengi daxil edin: ");
                    data[i].Color = data[i].Color.Replace(data[i].Color, newColor);
                    break;
                }
            }
        }
        public void EditEngine(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Masinin muherrikini deyisirsiniz ...");
                    string newEngine = ScanerMeneger.ReadString("Yeni muherriki daxil edin: ");
                    data[i].Engine = newEngine;
                    break;
                }
            }
        }
        public void EditFuelType(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Masinin yanacaq novunu deyisirsiniz...");
                    Fuel numFuel = ScanerMeneger.ReadFuelType("Yanacaq novunu secin: ");
                    switch (numFuel)
                    {
                        case Fuel.Gasoline:
                            data[i].Fuel = nameof(Fuel.Gasoline);
                            break;
                        case Fuel.Diesel:
                            data[i].Fuel = nameof(Fuel.Diesel);
                            break;
                        case Fuel.Hybrid:
                            data[i].Fuel = nameof(Fuel.Hybrid);
                            break;
                        case Fuel.Electro:
                            data[i].Fuel = nameof(Fuel.Electro);
                            break;
                        case Fuel.Gas:
                            data[i].Fuel = nameof(Fuel.Gas);
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
        }
        public void GetSingleCar(int value)
        {

            string singleCar = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    singleCar = $"Car ID: {data[i].Id} \n" +
                        $"| GraduationYear: {data[i].GraduationYear}\n" +
                        $"| Price: {data[i].Price}\n" +
                        $"| Color: {data[i].Color}\n" +
                        $"| Engine: {data[i].Engine}\n" +
                        $"| Fuel Type: {data[i].Fuel}\n" +
                        $"| Model ID: {data[i].ModelsId}";

                    break;
                }

            }
            Console.WriteLine("******************** Choosen car ********************");
            Console.WriteLine(singleCar);
        }
            public void Remove(Cars entity)
            {
            int index = Array.IndexOf(data, entity);

            if (index == -1)
            {
                return;
            }

            for (int i = index; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            if (data.Length > 0)
            {
                Array.Resize(ref data, data.Length - 1);
            }
        }
        public Cars[] GetAll()
        {
            return data;
        }
    }
}
