using ConsoleApp.ProjectCar.Infrastructure;
using ConsoleApp.ProjectCar.Manegers;
using System;
using System.Linq;


namespace ConsoleApp.ProjectCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Project Car ";
            
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
                case Menu.BrandsEdit:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    Console.WriteLine("Brendin adini deyisirsiz...");
                    int value = ScanerMeneger.ReadInteger("Secdiyiniz Brendin Id-sini daxil edin: ");
                    brandsMgr.BrandsEdit(value);
                    goto case Menu.BrandsAll;
                case Menu.BrandsRemove:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    int id = ScanerMeneger.ReadInteger("Silmek istediyiniz Markanin Id-sini daxil edin: ");
                    Brands g1 = brandsMgr.GetAll().FirstOrDefault(item => item.Id == id);
                    brandsMgr.Remove(g1);
                    goto case Menu.BrandsAll;   
                case Menu.BrandsSingle:
                    Console.Clear();
                    ShowAllBrands(brandsMgr);
                    int idValue = ScanerMeneger.ReadInteger("Etrafli baxmaq ucun istediyiniz Markanin Id-sini daxil edin: ");
                    Console.Clear();
                    brandsMgr.GetSingleBrand(idValue);
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
                    ShowAllBrands(brandsMgr);
                    a.BrandsId = ScanerMeneger.ReadInteger("Masinin marka Id-sini daxil edin: ");
                    modelsMgr.Add(a);
                    goto case Menu.ModelsAll;
                case Menu.ModelsEdit:
                    Console.Clear();
                    ShowAllModels(modelsMgr);
                    Console.WriteLine("Sec model -> 1 | Sec brand ID -> 2");
                    bool success = int.TryParse(Console.ReadLine(), out int modelChan);
                    if (success && modelChan == 1)
                    {
                        int valueMod = ScanerMeneger.ReadInteger("Secdiyin modelin Id-sini daxil et: ");
                        modelsMgr.EditModelName(valueMod);
                    }
                    else if (success && modelChan == 2)
                    {
                        int valueMod = ScanerMeneger.ReadInteger("Secdiyin modelin Id-sini daxil et: ");
                        modelsMgr.EditModelBrand(valueMod);
                    }

                    goto case Menu.ModelsAll;

                case Menu.ModelsRemove:
                    Console.Clear();
                    ShowAllModels(modelsMgr);
                    int idModelRem = ScanerMeneger.ReadInteger("Silmek istediyiniz Modelin Id-sini daxil edin: ");
                    Models m1 = modelsMgr.GetAll().FirstOrDefault(item => item.ModelId == idModelRem);
                    modelsMgr.Remove(m1);

                    goto case Menu.ModelsAll;

                case Menu.ModelsSingle:
                    Console.Clear();
                    ShowAllModels(modelsMgr);
                    int idModel = ScanerMeneger.ReadInteger("Etrafli baxmaq ucun istediyiniz Modelin Id-sini daxil edin: ");
                    Console.Clear();
                    modelsMgr.GetSingleModel(idModel);

                    goto readMenu;

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
                    PrintFuel();
                    Fuel f = ScanerMeneger.ReadFuelType("Yanacaq novunu secin: ");

                    switch (f)
                    {
                        case Fuel.Diesel:
                           c.Fuel = nameof(Fuel.Diesel);
                            break;
                        case Fuel.Gasoline:
                            c.Fuel= nameof (Fuel.Gasoline);    
                            break;
                        case Fuel.Hybrid:
                            c.Fuel = nameof(Fuel.Hybrid);
                            break;
                        case Fuel.Electro:
                            c.Fuel = nameof(Fuel.Electro);
                            break;
                        case Fuel.Gas:
                            c.Fuel = nameof(Fuel.Gas);
                            break;
                        default:
                            break;
                    }
                    c.Price = ScanerMeneger.ReadDouble("Qiymeti: ");
                    ShowAllModels(modelsMgr);
                    c.ModelsId = ScanerMeneger.ReadInteger("Masinin model Id-sini daxil edin: ");
                    carsMgr.Add(c);
                    goto case Menu.CarsAll;
                case Menu.CarsEdit:
                    Console.Clear();
                    ShowAllCars(carsMgr);
                    Console.WriteLine("Buraxilis ilini deyisin -> 1 \n" +
                        "Qiymetini deyisin -> 2 \n" +
                        "Rengini deyisin -> 3 \n" +
                        "Muherriki deyisin -> 4 \n" +
                        "Yanacaq novunu deyisin -> 5 \n" +
                        "Modeli deyisin -> 6");
                    bool successN = int.TryParse(Console.ReadLine(), out int carNumb);
                    if (successN && carNumb == 1)
                    {
                        int valueCar = ScanerMeneger.ReadInteger("Secilmis masinin Id-sini daxil edin: ");
                        carsMgr.EditYear(valueCar);
                    }
                    else if (successN && carNumb == 2)
                    {
                        int valueCar = ScanerMeneger.ReadInteger("Secilmis masinin Id-sini daxil edin: ");
                        carsMgr.EditPrice(valueCar);
                    }
                    else if (successN && carNumb == 3)
                    {
                        int valueCar = ScanerMeneger.ReadInteger("Secilmis masinin Id-sini daxil edin: ");
                        carsMgr.EditColor(valueCar);
                    }
                    else if (successN && carNumb == 4)
                    {
                        int valueCar = ScanerMeneger.ReadInteger("Secilmis masinin Id-sini daxil edin: ");
                        carsMgr.EditEngine(valueCar);

                    }
                    else if (successN && carNumb == 5)
                    {
                        int valueCar = ScanerMeneger.ReadInteger("Secilmis masinin Id-sini daxil edin: ");
                        Console.Clear();
                        PrintFuel();
                        carsMgr.EditFuelType(valueCar);
                    }
                    else if (successN && carNumb == 6)
                    {
                        int valueCar = ScanerMeneger.ReadInteger("Secilmis masinin Id-sini daxil edin: ");
                        ShowAllModels(modelsMgr);
                        carsMgr.EditCarModel(valueCar);
                    }
                    goto case Menu.CarsAll;
                case Menu.CarsRemove:
                    Console.Clear();
                    ShowAllCars(carsMgr);
                    int Id = ScanerMeneger.ReadInteger("Silmek istediyiniz Masinin Id-sini daxil edin: ");
                    Cars c1 = carsMgr.GetAll().FirstOrDefault(item => item.Id == Id);
                    carsMgr.Remove(c1);
                    goto case Menu.CarsAll;
                case Menu.CarsSingle:
                    Console.Clear();
                    ShowAllCars(carsMgr);
                    int idCar = ScanerMeneger.ReadInteger("Secdiyiniz masinin Id-sini daxil edin: ");
                    Console.Clear();
                    carsMgr.GetSingleCar(idCar);
                    goto readMenu;
                case Menu.CarsAll:
                    Console.Clear();
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
                Console.WriteLine($"{new string('+', Console.WindowWidth)}\n");
            }
        static void PrintFuel()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));
            foreach (var item in Enum.GetNames(typeof(Fuel)))
            {
                Fuel m = (Fuel)Enum.Parse(typeof(Fuel), item);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
                Console.ResetColor();
            }
            Console.WriteLine($"{new string('+', Console.WindowWidth)}\n");
        }

    }
}
