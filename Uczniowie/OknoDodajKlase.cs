﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uczniowie
{
    public partial class OknoDodajKlase : Form
    {
        public string NazwaKlasy
        {
            get
            {
                return textBoxKlasa.Text;
            }
        }

        public OknoDodajKlase()
        {
            InitializeComponent();
        }

        private void buttonDodajKlasa_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAnulujKlasa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
