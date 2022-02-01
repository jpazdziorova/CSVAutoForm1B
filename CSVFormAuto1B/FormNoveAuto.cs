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
    public partial class FormNoveAuto : Form
    {
        public FormNoveAuto()
        {
            InitializeComponent();
        }

        private void BtnPridejAuto_Click(object sender, EventArgs e)
        {
            Soubor.PridejAuto(TxtNazev.Text, int.Parse(TxtCena.Text));
        }
    }
}
