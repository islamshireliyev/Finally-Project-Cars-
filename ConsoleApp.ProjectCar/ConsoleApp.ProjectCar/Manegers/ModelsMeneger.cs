using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Manegers
{
    internal class ModelsMeneger
    {
        Models[] data = new Models[0];
        public void Add(Models entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }

        public void EditModelName(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ModelId == value)
                {
                    Console.WriteLine("Modeli secin...");
                    string newModel = ScanerMeneger.ReadString("Yeni modeli daxil edin: ");
                    data[i].Add=data[i].Add.Replace(data[i].Add, newModel);
                    break;
                }
            }
        }

        public void EditModelBrand(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ModelId == value)
                {
                    Console.WriteLine("Brendi secin...");
                    string newModel = ScanerMeneger.ReadString("Yeni Brendi daxil edin: ");
                    int newBrands = 0;
                    data[i].BrandsId = newBrands;
                    break;
                }
            }
        }

        public void GetSingleModel(int value)
        {
            string singleModel = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ModelId == value)
                {
                    singleModel = $"Model ID: {data[i].ModelId} | Model add: {data[i].Add} | Brand ID: {data[i].BrandsId} ";
                    break;
                }
            }
            Console.WriteLine("******************** Choosen model ********************");
            Console.WriteLine(singleModel);
        }

        public void Remove(Models entity)
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
        public Models[] GetAll()
        {
            return data;
        }
    }
}
