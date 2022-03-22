using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar
{
    internal class Models
    {

        public string Id { get; private set; }

        public string Add { get; set; }

        public int BrandsId { get; set; }

        public override string ToString()
        {
            return $"{BrandsId}. Model:{Add} ";
        }
        
    }
}
