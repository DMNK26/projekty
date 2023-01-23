using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uczniowie.Baza_danych.Model;

namespace Uczniowie
{
    public partial class OknoSzczegolyUczen : Form
    {
        public string OpisOkna
        {
            set
            {
                Text = value;
            }
        }
        public string OpisPrzyciskuOk
        {
            set
            {
                buttonOk.Text = value;
            }
        }
        public List<Klasa> ListaKlas
        {
            set
            {
                comboBoxKlasa.DataSource = value;
                comboBoxKlasa.DisplayMember = "NazwaKlasy";
            }
        }
        public string Imie
        {
            get
            {
                return textBoxImie.Text;
            }
            set
            {
                textBoxImie.Text = value;
            }
        }
        public string Nazwisko
        {
            get
            {
                return textBoxNazwisko.Text;
            }
            set
            {
                textBoxNazwisko.Text = value;
            }
        }
        public int RokUrodzenia
        {
            get
            {
                return (int)numericUpDownRok.Value;
            }
            set
            {
                numericUpDownRok.Value = value;
            }
        }
        public Klasa WybranaKlasa
        {
            get
            {
                return comboBoxKlasa.SelectedItem as Klasa;
            }
            set
            {
                comboBoxKlasa.SelectedItem = value;
            }
        }
        public OknoSzczegolyUczen()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
