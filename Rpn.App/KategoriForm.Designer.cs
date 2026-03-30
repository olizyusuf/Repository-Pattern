namespace Rpn.App
{
    partial class KategoriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.LvwKategori = new System.Windows.Forms.ListView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(7, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(97, 30);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Kategori";
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(13, 371);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(91, 36);
            this.BtnTambah.TabIndex = 2;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnUbah
            // 
            this.BtnUbah.Location = new System.Drawing.Point(119, 371);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(91, 36);
            this.BtnUbah.TabIndex = 3;
            this.BtnUbah.Text = "Ubah";
            this.BtnUbah.UseVisualStyleBackColor = true;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(224, 371);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(91, 36);
            this.BtnHapus.TabIndex = 4;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Location = new System.Drawing.Point(511, 371);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(91, 36);
            this.BtnKeluar.TabIndex = 5;
            this.BtnKeluar.Text = "Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            // 
            // LvwKategori
            // 
            this.LvwKategori.HideSelection = false;
            this.LvwKategori.Location = new System.Drawing.Point(12, 57);
            this.LvwKategori.Name = "LvwKategori";
            this.LvwKategori.Size = new System.Drawing.Size(590, 295);
            this.LvwKategori.TabIndex = 6;
            this.LvwKategori.UseCompatibleStateImageBehavior = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(527, 13);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 30);
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 422);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.LvwKategori);
            this.Controls.Add(this.BtnKeluar);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnUbah);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 461);
            this.MinimumSize = new System.Drawing.Size(631, 461);
            this.Name = "KategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repository Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnUbah;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.ListView LvwKategori;
        private System.Windows.Forms.Button BtnRefresh;
    }
}

