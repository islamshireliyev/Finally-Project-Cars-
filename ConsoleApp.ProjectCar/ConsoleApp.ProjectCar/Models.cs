using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar
{
    internal class Models
    {
        static int counter=0;
        public Models()
        {
            counter++;
            ModelId = counter;
        }
        public int ModelId { get; set; }

        public string Add { get; set; }

        public int BrandsId { get; set; }

        public override string ToString()
        {
            return $"ModelId: {ModelId} | Brand Id: {BrandsId}. | Model:{Add} ";
        }
        
    }
}
