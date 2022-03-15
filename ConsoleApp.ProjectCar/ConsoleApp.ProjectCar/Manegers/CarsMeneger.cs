using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Manegers
{
    internal class CarsMeneger
    {
        Cars[] data=new Cars[0];
        public void Add(Cars entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }
        public Cars[] GetAll()
        {
            return data;
        }
    }
}
