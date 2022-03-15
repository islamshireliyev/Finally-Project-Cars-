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
        BrandsId,


        CarsAdd,
        CarsEdit,
        CarsRemove,
        CarsSingle,
        CarsAll,
        ModelsId,
        All,
        Exit

        


    }
    public enum FullType
    {
        Diesel,
        Gsoline,
        Hybrid,
        Electricity
    }
}
