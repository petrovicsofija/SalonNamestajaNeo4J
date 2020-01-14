namespace SalonNamestaja
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblStanjeLager = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCena = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboSoba = new System.Windows.Forms.ComboBox();
            this.comboMaterijal = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboProizvod = new System.Windows.Forms.ComboBox();
            this.txtUloga = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTrazi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLager = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCena = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listProizvodi = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStaraCena = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStariLager = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(565, 104);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(70, 56);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lblStanjeLager
            // 
            this.lblStanjeLager.AutoSize = true;
            this.lblStanjeLager.BackColor = System.Drawing.Color.Transparent;
            this.lblStanjeLager.Location = new System.Drawing.Point(72, 184);
            this.lblStanjeLager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeLager.Name = "lblStanjeLager";
            this.lblStanjeLager.Size = new System.Drawing.Size(200, 21);
            this.lblStanjeLager.TabIndex = 2;
            this.lblStanjeLager.Text = "Novo stanje na lageru:";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.BackColor = System.Drawing.Color.Transparent;
            this.lblCena.Location = new System.Drawing.Point(152, 262);
            this.lblCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(111, 21);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Nova cena:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(136, 354);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 21);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Dodaj u Sobu:";
            // 
            // comboSoba
            // 
            this.comboSoba.FormattingEnabled = true;
            this.comboSoba.Items.AddRange(new object[] {
            "Dnevna Soba",
            "Spavaca Soba",
            "Decija Soba",
            "Hodnik",
            "Kuhinja",
            "Kupatilo",
            "Trpezarija",
            "Radna Soba"});
            this.comboSoba.Location = new System.Drawing.Point(279, 376);
            this.comboSoba.Name = "comboSoba";
            this.comboSoba.Size = new System.Drawing.Size(333, 29);
            this.comboSoba.TabIndex = 7;
            this.comboSoba.SelectedIndexChanged += new System.EventHandler(this.comboSoba_SelectedIndexChanged);
            // 
            // comboMaterijal
            // 
            this.comboMaterijal.FormattingEnabled = true;
            this.comboMaterijal.Location = new System.Drawing.Point(279, 500);
            this.comboMaterijal.Name = "comboMaterijal";
            this.comboMaterijal.Size = new System.Drawing.Size(333, 29);
            this.comboMaterijal.TabIndex = 8;
            this.comboMaterijal.SelectedIndexChanged += new System.EventHandler(this.comboMaterijal_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(143, 476);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 21);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Novi Matrijal:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(138, 43);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Tip Proizvoda:";
            // 
            // comboProizvod
            // 
            this.comboProizvod.FormattingEnabled = true;
            this.comboProizvod.Items.AddRange(new object[] {
            "Dekoracija",
            "Namestaj",
            "Rasveta",
            "Tehnika"});
            this.comboProizvod.Location = new System.Drawing.Point(279, 43);
            this.comboProizvod.Name = "comboProizvod";
            this.comboProizvod.Size = new System.Drawing.Size(333, 29);
            this.comboProizvod.TabIndex = 11;
            this.comboProizvod.SelectedIndexChanged += new System.EventHandler(this.comboProizvod_SelectedIndexChanged);
            // 
            // txtUloga
            // 
            this.txtUloga.Location = new System.Drawing.Point(466, 427);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(146, 28);
            this.txtUloga.TabIndex = 13;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(324, 434);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(117, 21);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Uloga u sobi:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTrazi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTrazi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTrazi.BorderThickness = 3;
            this.txtTrazi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrazi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTrazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTrazi.isPassword = false;
            this.txtTrazi.Location = new System.Drawing.Point(156, 116);
            this.txtTrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(370, 44);
            this.txtTrazi.TabIndex = 16;
            this.txtTrazi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTrazi.Enter += new System.EventHandler(this.txtTrazi_Enter);
            // 
            // txtLager
            // 
            this.txtLager.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLager.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLager.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLager.BorderThickness = 3;
            this.txtLager.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLager.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLager.isPassword = false;
            this.txtLager.Location = new System.Drawing.Point(242, 214);
            this.txtLager.Margin = new System.Windows.Forms.Padding(4);
            this.txtLager.Name = "txtLager";
            this.txtLager.Size = new System.Drawing.Size(161, 44);
            this.txtLager.TabIndex = 17;
            this.txtLager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCena
            // 
            this.txtCena.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCena.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCena.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCena.BorderThickness = 3;
            this.txtCena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCena.isPassword = false;
            this.txtCena.Location = new System.Drawing.Point(242, 297);
            this.txtCena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(161, 44);
            this.txtCena.TabIndex = 18;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(434, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // listProizvodi
            // 
            this.listProizvodi.FormattingEnabled = true;
            this.listProizvodi.Location = new System.Drawing.Point(725, 104);
            this.listProizvodi.Name = "listProizvodi";
            this.listProizvodi.Size = new System.Drawing.Size(310, 395);
            this.listProizvodi.TabIndex = 21;
            this.listProizvodi.SelectedIndexChanged += new System.EventHandler(this.listProizvodi_SelectedIndexChanged_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(766, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Obrisi Cekirane";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStaraCena
            // 
            this.txtStaraCena.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStaraCena.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaraCena.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStaraCena.BorderThickness = 3;
            this.txtStaraCena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaraCena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStaraCena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaraCena.isPassword = false;
            this.txtStaraCena.Location = new System.Drawing.Point(529, 297);
            this.txtStaraCena.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaraCena.Name = "txtStaraCena";
            this.txtStaraCena.Size = new System.Drawing.Size(161, 44);
            this.txtStaraCena.TabIndex = 26;
            this.txtStaraCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStariLager
            // 
            this.txtStariLager.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStariLager.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStariLager.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStariLager.BorderThickness = 3;
            this.txtStariLager.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStariLager.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStariLager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStariLager.isPassword = false;
            this.txtStariLager.Location = new System.Drawing.Point(529, 214);
            this.txtStariLager.Margin = new System.Windows.Forms.Padding(4);
            this.txtStariLager.Name = "txtStariLager";
            this.txtStariLager.Size = new System.Drawing.Size(161, 44);
            this.txtStariLager.TabIndex = 25;
            this.txtStariLager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(553, 262);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(137, 21);
            this.bunifuCustomLabel5.TabIndex = 24;
            this.bunifuCustomLabel5.Text = "Trenutna cena:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(459, 189);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(231, 21);
            this.bunifuCustomLabel6.TabIndex = 23;
            this.bunifuCustomLabel6.Text = "Trenutno stanje na Lageru:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(721, 67);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(225, 21);
            this.bunifuCustomLabel7.TabIndex = 27;
            this.bunifuCustomLabel7.Text = "Selektujte zeljeni proizvod:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(136, 91);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(302, 21);
            this.bunifuCustomLabel8.TabIndex = 28;
            this.bunifuCustomLabel8.Text = "Pretraga po delu imena proizvoda:";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 652);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.txtStaraCena);
            this.Controls.Add(this.txtStariLager);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listProizvodi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtLager);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtUloga);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.comboProizvod);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboMaterijal);
            this.Controls.Add(this.comboSoba);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblStanjeLager);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStanjeLager;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCena;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox comboSoba;
        private System.Windows.Forms.ComboBox comboMaterijal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox comboProizvod;
        private System.Windows.Forms.TextBox txtUloga;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTrazi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLager;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCena;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox listProizvodi;
        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStaraCena;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStariLager;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
    }
}