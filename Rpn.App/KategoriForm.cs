using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rpn.Model;
using Rpn.Repository.Api;
using Rpn.Repository.Service;

namespace Rpn.App
{
    public partial class KategoriForm : Form, IListener
    {
        private IKategoriRepository kategoriRepository;
        private IList<Kategori> listOfKategori;
        public KategoriForm()
        {
            InitializeComponent();
            InitListView();

            // implementasi class repository yang baru
            kategoriRepository = new KategoriRepository();

            LoadDataKategori();
        }

        private void InitListView()
        {
            LvwKategori.View = System.Windows.Forms.View.Details;
            LvwKategori.FullRowSelect = true;
            LvwKategori.GridLines = true;

            LvwKategori.Columns.Add("No.", 30, HorizontalAlignment.Center);
            LvwKategori.Columns.Add("Nama", 300, HorizontalAlignment.Left);
            LvwKategori.Columns.Add("Deskripsi", 325, HorizontalAlignment.Left);
        }

        private void FillToListView(bool isNewData, Kategori kategori)
        {
            if (isNewData)
            {
                int noUrut = LvwKategori.Items.Count + 1;

                ListViewItem item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(kategori.Nama);
                item.SubItems.Add(kategori.Deskripsi);

                LvwKategori.Items.Add(item);
            }
            else
            {
                int row = LvwKategori.SelectedIndices[0];

                ListViewItem itemRow = LvwKategori.Items[row];
                itemRow.SubItems[2].Text = kategori.Nama;
                itemRow.SubItems[3].Text = kategori.Deskripsi;
            }
        }

        private void LoadDataKategori()
        {
            LvwKategori.Items.Clear();

            if (listOfKategori == null)
            {
                listOfKategori = kategoriRepository.GetAll();
            }

            foreach (var kategori in listOfKategori)
            {
                FillToListView(true, kategori);
            }
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            var kategori = (Kategori)data;

            if (isNewData)
            {
                listOfKategori.Add(kategori);
            }
            else
            {
                var row = LvwKategori.SelectedIndices[0];
                listOfKategori[row] = kategori; 
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            var frmEntry = new KategoriEntryForm("Tambah Kategori", kategoriRepository);
            frmEntry.Listener = this;
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                LoadDataKategori();
            }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if(!(LvwKategori.SelectedItems.Count > 0))
            {
                MessageBox.Show("Pilih data yang akan diubah");
                return;
            }

            var row = LvwKategori.SelectedIndices[0];
            var kategori = listOfKategori[row];

            var frmEntry = new KategoriEntryForm("Ubah Kategori", kategori, kategoriRepository);
            frmEntry.Listener = this;
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                LoadDataKategori();
            }
            
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (!(LvwKategori.SelectedItems.Count > 0))
            {
                MessageBox.Show("Pilih data yang akan diubah");
                return;
            }

            var row = LvwKategori.SelectedIndices[0];
            var kategori = listOfKategori[row];

            string msg = "Apakah ada '" + kategori.Nama + "' yang akan diubah?";
            if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var result = 0;

                result = kategoriRepository.Hapus(kategori);

                if (result > 0)
                {
                    MessageBox.Show("Data kategori berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listOfKategori.Remove(kategori);
                    LoadDataKategori();
                }
            }
            else
            {
                 MessageBox.Show("Data kategori gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataKategori();
        }
    }
}
