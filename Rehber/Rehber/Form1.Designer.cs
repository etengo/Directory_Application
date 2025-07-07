namespace Rehber
{
    partial class Form1
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
            this.gbrehber = new System.Windows.Forms.GroupBox();
            this.gbyenikisi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.dgrehber = new System.Windows.Forms.DataGridView();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.gbrehber.SuspendLayout();
            this.gbyenikisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrehber)).BeginInit();
            this.SuspendLayout();
            // 
            // gbrehber
            // 
            this.gbrehber.Controls.Add(this.dgrehber);
            this.gbrehber.Location = new System.Drawing.Point(16, 18);
            this.gbrehber.Name = "gbrehber";
            this.gbrehber.Size = new System.Drawing.Size(893, 280);
            this.gbrehber.TabIndex = 30;
            this.gbrehber.TabStop = false;
            this.gbrehber.Text = "REHBER";
            // 
            // gbyenikisi
            // 
            this.gbyenikisi.Controls.Add(this.btngüncelle);
            this.gbyenikisi.Controls.Add(this.btnsil);
            this.gbyenikisi.Controls.Add(this.txtmail);
            this.gbyenikisi.Controls.Add(this.label5);
            this.gbyenikisi.Controls.Add(this.label4);
            this.gbyenikisi.Controls.Add(this.txtsoyad);
            this.gbyenikisi.Controls.Add(this.label3);
            this.gbyenikisi.Controls.Add(this.txtad);
            this.gbyenikisi.Controls.Add(this.label2);
            this.gbyenikisi.Controls.Add(this.btnekle);
            this.gbyenikisi.Controls.Add(this.txtid);
            this.gbyenikisi.Controls.Add(this.msktel);
            this.gbyenikisi.Controls.Add(this.label1);
            this.gbyenikisi.Location = new System.Drawing.Point(915, 18);
            this.gbyenikisi.Name = "gbyenikisi";
            this.gbyenikisi.Size = new System.Drawing.Size(381, 280);
            this.gbyenikisi.TabIndex = 15;
            this.gbyenikisi.TabStop = false;
            this.gbyenikisi.Text = "YENİ KİŞİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(94, 162);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(270, 30);
            this.msktel.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(270, 30);
            this.txtid.TabIndex = 15;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(94, 234);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(74, 30);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgrehber
            // 
            this.dgrehber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrehber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrehber.Location = new System.Drawing.Point(3, 26);
            this.dgrehber.Name = "dgrehber";
            this.dgrehber.RowHeadersWidth = 51;
            this.dgrehber.RowTemplate.Height = 24;
            this.dgrehber.Size = new System.Drawing.Size(887, 251);
            this.dgrehber.TabIndex = 20;
            this.dgrehber.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrehber_CellClick);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(94, 90);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(270, 30);
            this.txtad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(94, 126);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(270, 30);
            this.txtsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "TEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "MAIL:";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(94, 198);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(270, 30);
            this.txtmail.TabIndex = 4;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(174, 234);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(55, 30);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(235, 234);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(129, 30);
            this.btngüncelle.TabIndex = 7;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 307);
            this.Controls.Add(this.gbyenikisi);
            this.Controls.Add(this.gbrehber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbrehber.ResumeLayout(false);
            this.gbyenikisi.ResumeLayout(false);
            this.gbyenikisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrehber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrehber;
        private System.Windows.Forms.DataGridView dgrehber;
        private System.Windows.Forms.GroupBox gbyenikisi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
    }
}

