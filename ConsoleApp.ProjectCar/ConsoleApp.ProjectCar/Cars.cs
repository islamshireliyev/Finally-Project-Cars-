using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar
{
    internal class Cars
    {
        static int counter = 0;
        public Cars()
        {
            this.Id = ++counter;
        }
        public int Id { get; private set; }
        public DateTime GraduationYear { get; set; }

        public string Color { get; set; }

        public double Engine { get; set; }
        public string FullType { get; set; }
        public int ModelsId { get; set; }
        public override string ToString()
        {
            return $"{Id}. {GraduationYear:yyyy} {Color} {Engine}  ModelsId:{ModelsId}";
        }
    }
} 
