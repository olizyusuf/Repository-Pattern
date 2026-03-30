namespace Rpn.App
{
    partial class KategoriEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNama = new System.Windows.Forms.TextBox();
            this.TbDeskripsi = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(13, 9);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(83, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deskripsi";
            // 
            // TbNama
            // 
            this.TbNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNama.Location = new System.Drawing.Point(92, 52);
            this.TbNama.Name = "TbNama";
            this.TbNama.Size = new System.Drawing.Size(315, 29);
            this.TbNama.TabIndex = 3;
            // 
            // TbDeskripsi
            // 
            this.TbDeskripsi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDeskripsi.Location = new System.Drawing.Point(92, 92);
            this.TbDeskripsi.Name = "TbDeskripsi";
            this.TbDeskripsi.Size = new System.Drawing.Size(315, 29);
            this.TbDeskripsi.TabIndex = 4;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(332, 146);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 35);
            this.BtnSimpan.TabIndex = 5;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // KategoriEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 193);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TbDeskripsi);
            this.Controls.Add(this.TbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KategoriEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNama;
        private System.Windows.Forms.TextBox TbDeskripsi;
        private System.Windows.Forms.Button BtnSimpan;
    }
}