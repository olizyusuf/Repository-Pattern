
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rpn.Repository.Api;
using Rpn.Model;
using Rpn.Repository.Service;

namespace Rpn.App
{
    public partial class KategoriEntryForm : Form
    {
        private IKategoriRepository _kategoriRepository;
        private Kategori _kategori = null;
        private bool isNewData = false;

        public IListener Listener { get; set; }
        public KategoriEntryForm()
        {
            InitializeComponent();
        }

        public KategoriEntryForm(string judul, IKategoriRepository kategoriRepository) : this()
        {
            lblJudul.Text = judul;
            _kategoriRepository = kategoriRepository;
            isNewData = true;
        }

        public KategoriEntryForm(string judul, Kategori kategori, IKategoriRepository kategoriRepository) : this()
        {
            lblJudul.Text = judul;

            _kategori = kategori;
            _kategoriRepository = kategoriRepository;

            TbNama.Text = _kategori.Nama;
            TbDeskripsi.Text = _kategori.Deskripsi;

            
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {

            if (isNewData)
                _kategori = new Kategori();

            _kategori.Nama = TbNama.Text;
            _kategori.Deskripsi = TbDeskripsi.Text;

            var result = 0;

            if(isNewData)
                result = _kategoriRepository.Simpan(_kategori);
            else
                result = _kategoriRepository.Ubah(_kategori);

            if (result > 0)
            {
                Listener.Ok(this, isNewData, _kategori);

                if (isNewData)
                {
                    TbNama.Clear();
                    TbDeskripsi.Clear();
                    TbNama.Focus();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.Close();
                    this.DialogResult = DialogResult.OK;
            }
            else 
                MessageBox.Show("Gagal menyimpan data kategori", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
