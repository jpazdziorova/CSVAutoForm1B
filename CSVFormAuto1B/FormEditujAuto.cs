using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVFormAuto1B
{
    public partial class FormEditujAuto : Form
    {
        public int index;
        public FormEditujAuto()
        {
            InitializeComponent();
        }

        private void BtnEditujAuto_Click(object sender, EventArgs e)
        {
            Auto a = Soubor.Auta[index];
            a.Nazev = TxtNazev.Text;
            a.Cena = int.Parse(TxtCena.Text);
        }
    }
}
