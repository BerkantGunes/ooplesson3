using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IUrun
    {
        
         int ID { get; set; }
         string UrunAdi { get; set; }
        
        string UrunKodu {  get; set; } 
        
        string Aciklama { get; set; }


       

          
    }
}
