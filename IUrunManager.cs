using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IUrunManager
    {
        void Add();
        void Guncelle();
        void Delete();

        IEnumerable<IUrun> GetAll();


    }
}
