using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uczniowie.Baza_danych.Context;
using Uczniowie.Baza_danych.Model;

namespace Uczniowie
{
    public partial class OknoGlowne : Form
    {
        private MojaBazaContext bazaContext;
        private List<Klasa> listaKlas;
        public OknoGlowne()
        {
            InitializeComponent();

            bazaContext = new MojaBazaContext();
            ZaladujListeKlas();
            dataGridViewLista.AutoGenerateColumns = false;
        }        

        private void buttonOperacjeDodajKlase_Click(object sender, EventArgs e)
        {
            OknoDodajKlase oknoDodajKlase = new OknoDodajKlase();
            if (oknoDodajKlase.ShowDialog() == DialogResult.OK)
            {
                Klasa nowaKlasa = new Klasa()
                {
                    NazwaKlasy = oknoDodajKlase.NazwaKlasy
                };

                bazaContext.Klasy.Add(nowaKlasa);
                bazaContext.SaveChanges();
                ZaladujListeKlas();
            }
        }

        private void buttonOperacjeDodaj_Click(object sender, EventArgs e)
        {
            OknoSzczegolyUczen oknoSzczegolyUczen = new OknoSzczegolyUczen();
            oknoSzczegolyUczen.OpisOkna = "Dodaj ucznia";
            oknoSzczegolyUczen.OpisPrzyciskuOk = "Dodaj";
            List<Klasa> listaDlaOkna = listaKlas.ToList();
            listaDlaOkna.RemoveAt(0);
            oknoSzczegolyUczen.ListaKlas = listaDlaOkna;

            if(oknoSzczegolyUczen.ShowDialog() == DialogResult.OK)
            {
                Uczen nowyUczen = new Uczen()
                {
                    Imie = oknoSzczegolyUczen.Imie,
                    Nazwisko = oknoSzczegolyUczen.Nazwisko,
                    RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia,
                    KlasaId = oknoSzczegolyUczen.WybranaKlasa.Id
                };

                bazaContext.Add(nowyUczen);
                bazaContext.SaveChanges();
            }
        }

        private void ZaladujListeKlas()
        {
            listaKlas = bazaContext.Klasy.ToList();
            listaKlas.Insert(0, new Klasa()
            {
                Id = -1,
                NazwaKlasy = "<wszystkie>"
            });

            comboBoxFiltryKlasa.DataSource = listaKlas;
            comboBoxFiltryKlasa.DisplayMember = "NazwaKlasy";
        }

        private void buttonFiltrySzukaj_Click(object sender, EventArgs e)
        {
            int wybraneIdKlasy = (comboBoxFiltryKlasa.SelectedItem as Klasa).Id;

            var listaDocelowa = bazaContext.Uczniowie
                .Include(u => u.Klasa)
                .Where(u => wybraneIdKlasy == -1 || u.Klasa.Id == (comboBoxFiltryKlasa.SelectedItem as Klasa).Id)
                .Where(u => string.IsNullOrEmpty(textBoxFiltryImie.Text) || u.Imie.Contains(textBoxFiltryImie.Text))
                .Where(u => string.IsNullOrEmpty(textBoxFiltryNazwisko.Text) || u.Nazwisko.Contains(textBoxFiltryNazwisko.Text))
                .Where(u => string.IsNullOrEmpty(numericUpDownFiltryRok.Text.Trim()) || u.RokUrodzenia == ((int)numericUpDownFiltryRok.Value))
                .Select(u => new UczenGrid()
                {
                    Id = u.Id,
                    Imie = u.Imie,
                    Nazwisko = u.Nazwisko,
                    RokUrodzenia = u.RokUrodzenia,
                    NazwaKlasy = u.Klasa.NazwaKlasy,
                    Klasa = u.Klasa
                });
                
            dataGridViewLista.DataSource = listaDocelowa.ToList();
        }

        private void buttonOperacjeUsun_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy chcesz usunąć aktualny rekord?", "Usuwanie!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UczenGrid akutalnyWiersz = dataGridViewLista.CurrentRow?.DataBoundItem as UczenGrid;

                if(akutalnyWiersz != null)
                {
                    Uczen szukanyUczen = bazaContext.Uczniowie.Find(akutalnyWiersz.Id);
                    if(szukanyUczen != null)
                    {
                        bazaContext.Uczniowie.Remove(szukanyUczen);
                        bazaContext.SaveChanges();
                        MessageBox.Show("Kasowanie zakończone sukcesem!");
                        buttonFiltrySzukaj.PerformClick();
                    }
                }
            }
        }

        private void buttonOperacjeEdytuj_Click(object sender, EventArgs e)
        {
            OknoSzczegolyUczen oknoSzczegolyUczen = new OknoSzczegolyUczen();
            oknoSzczegolyUczen.OpisOkna = "Edytuj ucznia";
            oknoSzczegolyUczen.OpisPrzyciskuOk = "Zapisz";
            List<Klasa> listaDlaOkna = listaKlas.ToList();
            listaDlaOkna.RemoveAt(0);

            oknoSzczegolyUczen.ListaKlas = listaDlaOkna;

            UczenGrid aktualnyWiersz = dataGridViewLista.CurrentRow?.DataBoundItem as UczenGrid;

            if (aktualnyWiersz == null)
                return;

            oknoSzczegolyUczen.Imie = aktualnyWiersz.Imie;
            oknoSzczegolyUczen.Nazwisko = aktualnyWiersz.Nazwisko;
            oknoSzczegolyUczen.RokUrodzenia = aktualnyWiersz.RokUrodzenia;
            oknoSzczegolyUczen.WybranaKlasa = aktualnyWiersz.Klasa;

            if (oknoSzczegolyUczen.ShowDialog() == DialogResult.OK)
            {
                Uczen uczenDoModyfikacji = bazaContext.Uczniowie.Find(aktualnyWiersz.Id);
                if(uczenDoModyfikacji != null)
                {
                    uczenDoModyfikacji.Imie = oknoSzczegolyUczen.Imie;
                    uczenDoModyfikacji.Nazwisko = oknoSzczegolyUczen.Nazwisko;
                    uczenDoModyfikacji.RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia;
                    uczenDoModyfikacji.KlasaId = oknoSzczegolyUczen.WybranaKlasa.Id;
                    bazaContext.SaveChanges();

                    aktualnyWiersz.Imie = oknoSzczegolyUczen.Imie;
                    aktualnyWiersz.Nazwisko = oknoSzczegolyUczen.Nazwisko;
                    aktualnyWiersz.RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia;
                    aktualnyWiersz.Klasa = oknoSzczegolyUczen.WybranaKlasa;
                    dataGridViewLista.Refresh();
                }


               
            }
        }
    }
}
