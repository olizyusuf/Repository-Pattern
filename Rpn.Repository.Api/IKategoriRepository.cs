using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rpn.Model;

namespace Rpn.Repository.Api
{
    public interface IKategoriRepository : IBaseRepository<Kategori>
    {
        Kategori GetById(int kategoriId);
        IList<Kategori> GetByNama(string nama);
    }
}
