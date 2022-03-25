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
            counter++;
            Id = counter;
        }
        public int Id { get;  set; }
        public int ModelsId { get; set; }
        public DateTime GraduationYear { get; set; }

        public double Price { get; set; }

        public string Color { get; set; }

        public string Engine { get; set; }
        public string Fuel { get; set; }
       
        public override string ToString()
        {
            return $"{ ModelsId}" +
                   $" Buraxilis ili: {GraduationYear:yyyy}\n " +
                   $" qiymeti: {Price}.Azn \n " +
                   $" Rengi: {Color} \n" +
                   $" Muherrik: {Engine} \n" +
                   $" Yanacaq novu: {this.Fuel }\n";
        }          
    }
   
} 
