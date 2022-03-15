using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Manegers
{
    internal class ModelsMeneger
    {
        Models[] data = new Models[0];
        public void Add(Models entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }
        public Models[] GetAll()
        {
            return data;
        }
    }
}
