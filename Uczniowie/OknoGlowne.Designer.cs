
namespace Uczniowie
{
    partial class OknoGlowne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            this.GroupBoxFiltry = new System.Windows.Forms.GroupBox();
            this.buttonFiltrySzukaj = new System.Windows.Forms.Button();
            this.numericUpDownFiltryRok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFiltryKlasa = new System.Windows.Forms.ComboBox();
            this.textBoxFiltryNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxFiltryImie = new System.Windows.Forms.TextBox();
            this.labelFiltryRok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFiltryNazwisko = new System.Windows.Forms.Label();
            this.labelFiltryImie = new System.Windows.Forms.Label();
            this.groupBoxOperacje = new System.Windows.Forms.GroupBox();
            this.buttonOperacjeDodajKlase = new System.Windows.Forms.Button();
            this.buttonOperacjeUsun = new System.Windows.Forms.Button();
            this.buttonOperacjeEdytuj = new System.Windows.Forms.Button();
            this.buttonOperacjeDodaj = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.ColumnImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRokUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxFiltry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltryRok)).BeginInit();
            this.groupBoxOperacje.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxFiltry
            // 
            this.GroupBoxFiltry.Controls.Add(this.buttonFiltrySzukaj);
            this.GroupBoxFiltry.Controls.Add(this.numericUpDownFiltryRok);
            this.GroupBoxFiltry.Controls.Add(this.comboBoxFiltryKlasa);
            this.GroupBoxFiltry.Controls.Add(this.textBoxFiltryNazwisko);
            this.GroupBoxFiltry.Controls.Add(this.textBoxFiltryImie);
            this.GroupBoxFiltry.Controls.Add(this.labelFiltryRok);
            this.GroupBoxFiltry.Controls.Add(this.label3);
            this.GroupBoxFiltry.Controls.Add(this.labelFiltryNazwisko);
            this.GroupBoxFiltry.Controls.Add(this.labelFiltryImie);
            this.GroupBoxFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxFiltry.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxFiltry.Name = "GroupBoxFiltry";
            this.GroupBoxFiltry.Size = new System.Drawing.Size(798, 79);
            this.GroupBoxFiltry.TabIndex = 0;
            this.GroupBoxFiltry.TabStop = false;
            this.GroupBoxFiltry.Text = "Filtr:";
            // 
            // buttonFiltrySzukaj
            // 
            this.buttonFiltrySzukaj.Location = new System.Drawing.Point(701, 22);
            this.buttonFiltrySzukaj.Name = "buttonFiltrySzukaj";
            this.buttonFiltrySzukaj.Size = new System.Drawing.Size(75, 41);
            this.buttonFiltrySzukaj.TabIndex = 8;
            this.buttonFiltrySzukaj.Text = "Szukaj";
            this.buttonFiltrySzukaj.UseVisualStyleBackColor = true;
            this.buttonFiltrySzukaj.Click += new System.EventHandler(this.buttonFiltrySzukaj_Click);
            // 
            // numericUpDownFiltryRok
            // 
            this.numericUpDownFiltryRok.Location = new System.Drawing.Point(496, 40);
            this.numericUpDownFiltryRok.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numericUpDownFiltryRok.Name = "numericUpDownFiltryRok";
            this.numericUpDownFiltryRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownFiltryRok.TabIndex = 7;
            // 
            // comboBoxFiltryKlasa
            // 
            this.comboBoxFiltryKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltryKlasa.FormattingEnabled = true;
            this.comboBoxFiltryKlasa.Location = new System.Drawing.Point(330, 40);
            this.comboBoxFiltryKlasa.Name = "comboBoxFiltryKlasa";
            this.comboBoxFiltryKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFiltryKlasa.TabIndex = 6;
            // 
            // textBoxFiltryNazwisko
            // 
            this.textBoxFiltryNazwisko.Location = new System.Drawing.Point(184, 40);
            this.textBoxFiltryNazwisko.Name = "textBoxFiltryNazwisko";
            this.textBoxFiltryNazwisko.Size = new System.Drawing.Size(100, 23);
            this.textBoxFiltryNazwisko.TabIndex = 5;
            // 
            // textBoxFiltryImie
            // 
            this.textBoxFiltryImie.Location = new System.Drawing.Point(43, 39);
            this.textBoxFiltryImie.Name = "textBoxFiltryImie";
            this.textBoxFiltryImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxFiltryImie.TabIndex = 4;
            // 
            // labelFiltryRok
            // 
            this.labelFiltryRok.AutoSize = true;
            this.labelFiltryRok.Location = new System.Drawing.Point(496, 22);
            this.labelFiltryRok.Name = "labelFiltryRok";
            this.labelFiltryRok.Size = new System.Drawing.Size(30, 15);
            this.labelFiltryRok.TabIndex = 3;
            this.labelFiltryRok.Text = "Rok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Klasa:";
            // 
            // labelFiltryNazwisko
            // 
            this.labelFiltryNazwisko.AutoSize = true;
            this.labelFiltryNazwisko.Location = new System.Drawing.Point(184, 22);
            this.labelFiltryNazwisko.Name = "labelFiltryNazwisko";
            this.labelFiltryNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelFiltryNazwisko.TabIndex = 1;
            this.labelFiltryNazwisko.Text = "Nazwisko:";
            // 
            // labelFiltryImie
            // 
            this.labelFiltryImie.AutoSize = true;
            this.labelFiltryImie.Location = new System.Drawing.Point(43, 22);
            this.labelFiltryImie.Name = "labelFiltryImie";
            this.labelFiltryImie.Size = new System.Drawing.Size(33, 15);
            this.labelFiltryImie.TabIndex = 0;
            this.labelFiltryImie.Text = "Imie:";
            // 
            // groupBoxOperacje
            // 
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeDodajKlase);
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeUsun);
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeEdytuj);
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeDodaj);
            this.groupBoxOperacje.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOperacje.Location = new System.Drawing.Point(675, 79);
            this.groupBoxOperacje.Name = "groupBoxOperacje";
            this.groupBoxOperacje.Size = new System.Drawing.Size(123, 369);
            this.groupBoxOperacje.TabIndex = 1;
            this.groupBoxOperacje.TabStop = false;
            this.groupBoxOperacje.Text = "Operacje";
            // 
            // buttonOperacjeDodajKlase
            // 
            this.buttonOperacjeDodajKlase.Location = new System.Drawing.Point(26, 246);
            this.buttonOperacjeDodajKlase.Name = "buttonOperacjeDodajKlase";
            this.buttonOperacjeDodajKlase.Size = new System.Drawing.Size(75, 48);
            this.buttonOperacjeDodajKlase.TabIndex = 3;
            this.buttonOperacjeDodajKlase.Text = "Dodaj Klase";
            this.buttonOperacjeDodajKlase.UseVisualStyleBackColor = true;
            this.buttonOperacjeDodajKlase.Click += new System.EventHandler(this.buttonOperacjeDodajKlase_Click);
            // 
            // buttonOperacjeUsun
            // 
            this.buttonOperacjeUsun.Location = new System.Drawing.Point(26, 179);
            this.buttonOperacjeUsun.Name = "buttonOperacjeUsun";
            this.buttonOperacjeUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeUsun.TabIndex = 2;
            this.buttonOperacjeUsun.Text = "Usuń";
            this.buttonOperacjeUsun.UseVisualStyleBackColor = true;
            this.buttonOperacjeUsun.Click += new System.EventHandler(this.buttonOperacjeUsun_Click);
            // 
            // buttonOperacjeEdytuj
            // 
            this.buttonOperacjeEdytuj.Location = new System.Drawing.Point(26, 127);
            this.buttonOperacjeEdytuj.Name = "buttonOperacjeEdytuj";
            this.buttonOperacjeEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeEdytuj.TabIndex = 1;
            this.buttonOperacjeEdytuj.Text = "Edytuj";
            this.buttonOperacjeEdytuj.UseVisualStyleBackColor = true;
            this.buttonOperacjeEdytuj.Click += new System.EventHandler(this.buttonOperacjeEdytuj_Click);
            // 
            // buttonOperacjeDodaj
            // 
            this.buttonOperacjeDodaj.Location = new System.Drawing.Point(26, 75);
            this.buttonOperacjeDodaj.Name = "buttonOperacjeDodaj";
            this.buttonOperacjeDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeDodaj.TabIndex = 0;
            this.buttonOperacjeDodaj.Text = "Dodaj";
            this.buttonOperacjeDodaj.UseVisualStyleBackColor = true;
            this.buttonOperacjeDodaj.Click += new System.EventHandler(this.buttonOperacjeDodaj_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.dataGridViewLista);
            this.groupBoxLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLista.Location = new System.Drawing.Point(0, 79);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(675, 369);
            this.groupBoxLista.TabIndex = 2;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista";
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImie,
            this.ColumnNazwisko,
            this.ColumnKlasa,
            this.ColumnRokUrodzenia});
            this.dataGridViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLista.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.RowTemplate.Height = 25;
            this.dataGridViewLista.Size = new System.Drawing.Size(669, 347);
            this.dataGridViewLista.TabIndex = 0;
            // 
            // ColumnImie
            // 
            this.ColumnImie.DataPropertyName = "Imie";
            this.ColumnImie.HeaderText = "Imie";
            this.ColumnImie.Name = "ColumnImie";
            this.ColumnImie.ReadOnly = true;
            // 
            // ColumnNazwisko
            // 
            this.ColumnNazwisko.DataPropertyName = "Nazwisko";
            this.ColumnNazwisko.HeaderText = "Nazwisko";
            this.ColumnNazwisko.Name = "ColumnNazwisko";
            this.ColumnNazwisko.ReadOnly = true;
            // 
            // ColumnKlasa
            // 
            this.ColumnKlasa.DataPropertyName = "NazwaKlasy";
            this.ColumnKlasa.HeaderText = "Klasa";
            this.ColumnKlasa.Name = "ColumnKlasa";
            this.ColumnKlasa.ReadOnly = true;
            // 
            // ColumnRokUrodzenia
            // 
            this.ColumnRokUrodzenia.DataPropertyName = "RokUrodzenia";
            this.ColumnRokUrodzenia.HeaderText = "Rok urodzenia";
            this.ColumnRokUrodzenia.Name = "ColumnRokUrodzenia";
            this.ColumnRokUrodzenia.ReadOnly = true;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxOperacje);
            this.Controls.Add(this.GroupBoxFiltry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(814, 487);
            this.Name = "OknoGlowne";
            this.Text = "Baza Danych Uczniowie";
            this.GroupBoxFiltry.ResumeLayout(false);
            this.GroupBoxFiltry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltryRok)).EndInit();
            this.groupBoxOperacje.ResumeLayout(false);
            this.groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxFiltry;
        private System.Windows.Forms.Button buttonFiltrySzukaj;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltryRok;
        private System.Windows.Forms.ComboBox comboBoxFiltryKlasa;
        private System.Windows.Forms.TextBox textBoxFiltryNazwisko;
        private System.Windows.Forms.TextBox textBoxFiltryImie;
        private System.Windows.Forms.Label labelFiltryRok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFiltryNazwisko;
        private System.Windows.Forms.Label labelFiltryImie;
        private System.Windows.Forms.GroupBox groupBoxOperacje;
        private System.Windows.Forms.Button buttonOperacjeDodajKlase;
        private System.Windows.Forms.Button buttonOperacjeUsun;
        private System.Windows.Forms.Button buttonOperacjeEdytuj;
        private System.Windows.Forms.Button buttonOperacjeDodaj;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRokUrodzenia;
    }
}

