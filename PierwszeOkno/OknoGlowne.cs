using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierwszeOkno
{
    public partial class OknoGlowne : Form
    {
        Random random = new Random();

        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Shalom";
            button1.Text = "Zostaw Mnie!";
            Text = "tf";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = random.Next(0, Size.Width - button1.Width);
            int y = random.Next(0, Size.Height - button1.Height);
            Point point = new Point(x, y);

            button1.Location = point;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Widzisz mnie?", "Witaj byczku", MessageBoxButtons.YesNo);
        }
    }
}
