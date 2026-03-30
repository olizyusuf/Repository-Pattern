using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Rpn.Model;
using Rpn.Repository.Api;
using Dapper;

namespace Rpn.Repository.Service
{
    public class KategoriRepository : IKategoriRepository
    {
        private string _sql;

        public KategoriRepository()
        {

        }

        public IList<Kategori> GetAll()
        {
            IList<Kategori> listOfKategori = new List<Kategori>();

            try
            {
                _sql = @"SELECT KategoriID, Nama, Deskripsi FROM Kategori ORDER BY Nama";

                using (IDapperContext context = new DapperContext())
                {
                    listOfKategori = context.db.Query<Kategori>(_sql).ToList();
                }

            }
            catch (Exception ex)    
            {
                Console.WriteLine(ex.Message);
            }
            return listOfKategori;
        }

        public Kategori GetById(int kategoriId)
        {
            Kategori kategori = null;

            try
            {
                _sql = @"SELECT KategoriID, Nama, Deskripsi FROM Kategori WHERE KategoriID = @KategoriID";
                using (IDapperContext context = new DapperContext())
                {
                    kategori = context.db.Query<Kategori>(_sql, new { KategoriID = kategoriId }).SingleOrDefault();
                }
            }
            catch
            {
                
            }
            return kategori;
        }

        public IList<Kategori> GetByNama(string nama)
        {
            IList<Kategori> listOfKategori = new List<Kategori>();

            try
            {
                _sql = @"SELECT KategoriID, Nama, Deskripsi FROM Kategori WHERE Nama LIKE @Nama ORDER BY Nama";
                
                nama = string.Format("%{0}%", nama);

                using (IDapperContext context = new DapperContext())
                {
                    listOfKategori = context.db.Query<Kategori>(_sql, new { Nama = nama }).ToList();
                }
            }
            catch
            {
            }
            return listOfKategori;
        }

        public int Simpan(Kategori obj)
        {
            var result = 0;

            try
            {
                _sql = @"INSERT INTO Kategori (Nama, Deskripsi) VALUES (@Nama, @Deskripsi)";

                using (IDapperContext context = new DapperContext())
                {
                    result = context.db.Execute(_sql, new { Nama = obj.Nama, Deskripsi = obj.Deskripsi });

                    if (result > 0)
                    {
                        obj.KategoriID = context.GetLastId();
                    }
                }
            }

            catch
            {
            }

            return result;
        }

        public int Ubah(Kategori obj)
        {
            var result = 0;

            try
            {
                _sql = @"UPDATE Kategori SET Nama = @Nama, Deskripsi = @Deskripsi WHERE KategoriID = @KategoriID";
                using (IDapperContext context = new DapperContext())
                {
                    result = context.db.Execute(_sql, new { Nama = obj.Nama, Deskripsi = obj.Deskripsi, KategoriID = obj.KategoriID });
                }
            }
            catch
            {
            }

            return result;
        }

        public int Hapus(Kategori obj)
        {
            var result = 0;

            try
            {
                _sql = @"DELETE FROM Kategori WHERE KategoriID = @KategoriID";
                using (IDapperContext context = new DapperContext())
                {
                    result = context.db.Execute(_sql, new { KategoriID = obj.KategoriID });
                }
            }
            catch
            {
            }

            return result;
        }

       
    }
}
