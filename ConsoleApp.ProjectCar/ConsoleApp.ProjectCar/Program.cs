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
            Console.Title = "Project Car C.1";

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
                    g.Name = ScanerMeneger.ReadString("Masinin brendi: ");
                    brandsMgr.Add(g);
                    goto  case Menu.BrandsAll;
                    break;
                case Menu.BrandsEdit:

                    break;
                case Menu.BrandsRemove:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    int id = ScanerMeneger.ReadInteger("Silmek istediyiniz Markanin Id-sini daxil edin");
                    Brands g1 = brandsMgr.GetAll().FirstOrDefault(item => item.Id == id);
                    brandsMgr.Remove(g1);
                    goto case Menu.BrandsAll;   
                case Menu.BrandsSingle:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    int idForSingle = ScanerMeneger.ReadInteger("Etrafli baxmaq ucun istediyiniz Markanin Id-sini daxil edin: ");
                    Brands gSingle = brandsMgr.GetAll().FirstOrDefault(item => item.Id == idForSingle);

                    Console.WriteLine($"--------------------------\n" +
                        $"Name: {gSingle.Name}\n--------------------------");
                    goto readMenu;
                case Menu.BrandsAll:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    goto readMenu;
                    break;
                case Menu.ModelsAdd:
                    Console.Clear();
                    Models a = new Models();
                    a.Add = ScanerMeneger.ReadString("Masinin modeli: ");
                    Console.WriteLine("--------------------------------------");
                    ShowAllBrands(brandsMgr);
                    Console.WriteLine("--------------------------------------");
                    a.BrandsId = ScanerMeneger.ReadInteger("Masinin marka Id-sini daxil edin: ");
                    modelsMgr.Add(a);
                    goto case Menu.ModelsAll;
                case Menu.ModelsAll:
                    Console.Clear();
                    ShowAllModels(modelsMgr);
                    goto readMenu;
               
                case Menu.CarsAdd:
                    Console.Clear();
                    Cars c = new Cars();
                    c.Color = ScanerMeneger.ReadString("Masinin rengi: ");
                    c.GraduationYear = ScanerMeneger.ReadDate("Masinin buraxilis ili: ");
                    c.Engine = ScanerMeneger.ReadString("Masinin muherriki: ");
                    c.FullType = ScanerMeneger.ReadString("Yanacaq novu: ");
                    c.Price = ScanerMeneger.ReadDouble("Qiymetini: ");
                    Console.WriteLine("-----------------------------------");
                    ShowAllModels(modelsMgr);
                    Console.WriteLine("-----------------------------------");
                    c.ModelsId = ScanerMeneger.ReadInteger("Masinin model Id-sini daxil edin: ");
                    carsMgr.Add(c);
                    goto case Menu.CarsAll;
                    break;
                case Menu.CarsEdit:
                    break;
                case Menu.CarsRemove:
                    Console.Clear();
                    ShowAllCars(carsMgr);
                    int Id = ScanerMeneger.ReadInteger("Silmek istediyiniz Masinin Id-sini daxil edin");
                    Cars c1 = carsMgr.GetAll().FirstOrDefault(item => item.Id == Id);
                    carsMgr.Remove(c1);
                    goto case Menu.CarsAll;
                    
                case Menu.CarsSingle:
                    Console.Clear();
                    ShowAllCars(carsMgr);
                     idForSingle = ScanerMeneger.ReadInteger("Etrafli baxmaq ucun istediyiniz Markanin Id-sini daxil edin: ");
                    Cars cSingle = carsMgr.GetAll().FirstOrDefault(item => item.Id == idForSingle);

                    Console.WriteLine($"--------------------------\n" +
                        $"Id: {cSingle.Id}\n--------------------------");
                    goto readMenu;
                case Menu.CarsAll:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    ShowAllModels(modelsMgr);
                    ShowAllCars(carsMgr);
                    goto readMenu;
                case Menu.All:
                    Console.Clear();
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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
                Console.ResetColor();
                }
                Console.WriteLine($"{new string('+', Console.WindowWidth)}");
            }

    }
}
