using ConsoleApp.ProjectCar.Infrastructure;
using ConsoleApp.ProjectCar.Manegers;
using System;
using System.Linq;
using System.Text;

namespace ConsoleApp.ProjectCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Project Car a.1";

            var brandsMgr = new BrandsMeneger();
            var carsMgr = new CarsMeneger();
            var modelsMgr = new ModelsMeneger();

        readMenu:
            PrintMenu();
            Menu m = ScanerMeneger.ReadMenu("Menudan secin: ");

            switch (m)
            {
                case Menu.BrandsAdd:
                    Console.Clear();
                    Brands g = new Brands();
                    g.Name = ScanerMeneger.ReadString("Masinin brendi: "); ;
                    brandsMgr.Add(g);
                    goto  case Menu.BrandsAll;
                    break;
                case Menu.BrandsEdit:
                    break;
                case Menu.BrandsRemove:
                    Brands g1 = brandsMgr.GetAll().FirstOrDefault(g => g.Id == 4);
                    break;
                case Menu.BrandsSingle:
                    break;
                case Menu.BrandsAll:
                    //Console.Clear();
                    ShowAllBrands(brandsMgr);
                    goto readMenu;
                    break;
               
                case Menu.ModelsAdd:
                    Console.Clear();
                    Models a = new Models();
                    a.Add = ScanerMeneger.ReadString("Masinin modeli: ");
                    
                    ShowAllBrands(brandsMgr);
                    
                    a.BrandsId = ScanerMeneger.ReadInteger("Masinin marka Id-sini daxil edin");
                    modelsMgr.Add(a);
                    goto case Menu.ModelsAll;
                    break;
                case Menu.ModelsAll:
                    //Console.Clear();
                    ShowAllModels(modelsMgr);
                    goto readMenu;
                    break;
                case Menu.BrandsId:
                    break;
                case Menu.CarsAdd:
                    Console.Clear();
                    Cars c = new Cars();
                    c.Color = ScanerMeneger.ReadString("Masinin rengi: ");
                    c.GraduationYear = ScanerMeneger.ReadDate("Masinin buraxilis ili:");
                    c.Engine = ScanerMeneger.ReadDouble("Masinin muherriki: ");
                    c.FullType = ScanerMeneger.ReadString("Yanacaq novu: ");

                    Console.WriteLine("-----------------------------------");
                    ShowAllBrands(brandsMgr);
                    Console.WriteLine("-----------------------------------");
                    c.ModelsId = ScanerMeneger.ReadInteger("Masinin model Id-sini daxil edin");
                    carsMgr.Add(c);
                    goto case Menu.CarsAll;
                    break;
                case Menu.CarsEdit:
                    break;
                case Menu.CarsRemove:
                    break;
                case Menu.CarsSingle:
                    break;
                case Menu.CarsAll:
                    Console.Clear();
                    ShowAllCars(carsMgr);
                    goto readMenu;
                    break;
                case Menu.All:
                    //Console.Clear();
                    ShowAllBrands(brandsMgr);
                    ShowAllModels(modelsMgr);
                    ShowAllCars(carsMgr);
                    goto readMenu;
                case Menu.Exit:
                    goto lEnd;
                    break;
                default:
                    break;
            }
        lEnd:
            Console.WriteLine("End...........");
            Console.WriteLine("Cixmaq ucun her hansi bir duymeni sixin");
            Console.ReadLine();
        }
        static void ShowAllBrands(BrandsMeneger brandsMgr)
        {

                Console.WriteLine("------------------------ Brands ------------------------");
                foreach (var item in brandsMgr.GetAll())
                {
                    Console.WriteLine(item);
                }
        }
        static void ShowAllModels(ModelsMeneger modelsMgr)
        {

                 Console.WriteLine("------------------------ Models ------------------------");
                foreach (var item in modelsMgr.GetAll())
                {
                    Console.WriteLine(item);
                }
        }
        static void ShowAllCars(CarsMeneger carsMgr)
        {

                Console.WriteLine("------------------------ Cars ------------------------");
                foreach (var item in carsMgr.GetAll())
                {
                    Console.WriteLine(item);
                }
        }
       

        static void PrintMenu()
            {
                Console.WriteLine(new string('-', Console.WindowWidth));
                foreach (var item in Enum.GetNames(typeof(Menu)))
                {
                    Menu m = (Menu)Enum.Parse(typeof(Menu), item);

                    Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
                }
                Console.WriteLine($"{new string('+', Console.WindowWidth)}\n");
            }






    }
}
