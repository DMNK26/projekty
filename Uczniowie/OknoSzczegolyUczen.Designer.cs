
namespace Uczniowie
{
    partial class OknoSzczegolyUczen
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
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.labelRok = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.numericUpDownRok = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(23, 31);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(30, 15);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(132, 31);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(57, 15);
            this.labelNazwisko.TabIndex = 1;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(238, 31);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(34, 15);
            this.labelKlasa.TabIndex = 2;
            this.labelKlasa.Text = "Klasa";
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Location = new System.Drawing.Point(365, 31);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(27, 15);
            this.labelRok.TabIndex = 3;
            this.labelRok.Text = "Rok";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(23, 49);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxImie.TabIndex = 4;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(132, 49);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwisko.TabIndex = 5;
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(238, 49);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKlasa.TabIndex = 6;
            // 
            // numericUpDownRok
            // 
            this.numericUpDownRok.Location = new System.Drawing.Point(365, 49);
            this.numericUpDownRok.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numericUpDownRok.Name = "numericUpDownRok";
            this.numericUpDownRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRok.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(132, 88);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(283, 88);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 9;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // OknoSzczegolyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 123);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownRok);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelRok);
            this.Controls.Add(this.labelKlasa);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Name = "OknoSzczegolyUczen";
            this.Text = "OknoSzczegolyUczen";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.Label labelRok;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.NumericUpDown numericUpDownRok;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}