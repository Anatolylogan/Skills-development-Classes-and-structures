using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Creating_a_method_inside_a_class
{
    class User
    {
        public string Name;
        public int Age;

        public void DisplayInfo()
        {
            string messege = $"Имя:{Name} Возраст:{Age}";
            Console.WriteLine(messege);
        }
        
    }
    
}
