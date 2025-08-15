using lab77.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab77.Models
{
    abstract class App
    {
        public App (string obyekt)
        {
            Count++;       
            Id = Count;    


            Obyekt = obyekt.Capitalize();
            

            
        }
    }
}
