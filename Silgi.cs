using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Silgi : IUrun
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string UrunAdi { get; set; }
        [Key]
        [MaxLength(50)]
        public string UrunKodu { get; set; }
        [MaxLength(250)]
        public string Aciklama { get; set; }
    }
}
