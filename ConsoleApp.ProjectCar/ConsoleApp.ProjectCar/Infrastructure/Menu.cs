using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Infrastructure
{
    internal enum Menu :byte
    {
        
        BrandsAdd = 1,
        BrandsEdit,
        BrandsRemove,
        BrandsSingle,
        BrandsAll,

        
        ModelsAdd,
        ModelsEdit,
        ModelsRemove,
        ModelsSingle,
        ModelsAll,
        


        CarsAdd,
        CarsEdit,
        CarsRemove,
        CarsSingle,
        CarsAll,
        
        All,
        Exit

    }
   
}
