using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Manegers
{
    internal class BrandsMeneger
    {
        Brands[] data=new Brands[0];


        public void Add(Brands entity)
        {
            int len=data.Length;
            Array.Resize(ref data,len+1);
            data[len] = entity;
        }

        public void Remove(Brands entity)
        {
            int index = Array.IndexOf(data, entity);

            if (index == -1)
            {
                return;
            }
            for (int i = index; i < data.Length-1; i++)
            {
                data[i] = data[i + 1];
            }
            if (data.Length > 0)
            {
                Array.Resize(ref data, data.Length - 1);
            }
        }

        public void BrandsEdit(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    Console.WriteLine("Brend adini sec...");
                    string newNameBrand = ScanerMeneger.ReadString("Brend adini daxil edin: ");
                    data[i].Name = data[i].Name.Replace(data[i].Name, newNameBrand);
                    break;
                }
            }
        }
        public void GetSingleBrand(int value)
        {
            
            string singleBrands = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Id == value)
                {
                    singleBrands = $"Brand ID: {data[i].Id} | Brand name: {data[i].Name} ";
                   
                    break;
                }
            }
            Console.WriteLine("******************** Brands ********************");
            Console.WriteLine(singleBrands);
           
        }
        public Brands[] GetAll()
        {
            return data;
        }
    }
}
