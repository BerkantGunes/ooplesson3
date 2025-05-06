using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class UrunManager : IUrunManager
    {
        public void Add()
        {
            string durum = "Eklendi";
        }

        public void Delete()
        {
            string durum = "Silindi";
        }

        public IEnumerable<IUrun> GetAll()
        {
            List<IUrun> uruns = new List<IUrun>();
            foreach (var ur in uruns)
            {
                uruns.Add(ur);
            }
            return uruns;
        }

        public void Guncelle()
        {
            string durum = "Güncellendi";
        }
    }
}
