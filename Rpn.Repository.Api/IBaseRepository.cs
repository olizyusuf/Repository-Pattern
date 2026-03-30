using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpn.Repository.Api
{
    public interface IBaseRepository<T> where T : class
    {
        int Simpan(T obj);
        int Ubah(T obj);
        int Hapus(T obj);
        IList<T> GetAll();
    }
}
