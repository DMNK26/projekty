using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pesel.Model;
namespace Pesel
{
    public partial class OknoGlowne : Form
    {
        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Pesel pesel = new Model.Pesel(textBoxPesel.Text);
                labelNapisPesel.Text = @"Podany PESEL: " + pesel.NumerPesel;
                labelPlec.Text = @"Płeć: " + pesel.Plec;
                labelData.Text = @"Data urodzenia: " + pesel.Data;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, @"Błąd");
            }

        }

        private void textBoxPesel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonEnter.PerformClick();
            }
        }
    }
}
