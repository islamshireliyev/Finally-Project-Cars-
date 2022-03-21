using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Infrastructure
{
    public enum Menu :byte
    {
        
        BrandsAdd = 1,
        BrandsEdit,
        BrandsRemove,
        BrandsSingle,
        BrandsAll,

        
        ModelsAdd,
        ModelsAll,
        


        CarsAdd,
        CarsEdit,
        CarsRemove,
        CarsSingle,
        CarsAll,
        
        All,
        Exit

    }
    public enum FullType :byte
    {
        Diesel,
        Gasoline,
        Hybrid,
        Electricity
    }
}
