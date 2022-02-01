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
    public partial class FormHlavni : Form
    {
        public FormHlavni()
        {
            InitializeComponent();
        }

        private void FormHlavni_Load(object sender, EventArgs e)
        {
            LBAuta.Items.Clear();
            Soubor.Nacti();
            foreach(Auto a in Soubor.Auta)
            {
                LBAuta.Items.Add(a);
            }
        }

        private void BtnNoveAuto_Click(object sender, EventArgs e)
        {
            using (FormNoveAuto f = new FormNoveAuto())
            {
                f.ShowDialog();
            }
            //zobrazení obsahu listu Auta v listboxu
            LBAuta.Items.Clear();
            foreach(Auto a in Soubor.Auta)
            {
                LBAuta.Items.Add(a);
            }
        }

        private void BtnUloz_Click(object sender, EventArgs e)
        {
            Soubor.Uloz();
        }

        private void BtnEditujAuto_Click(object sender, EventArgs e)
        {
            using (FormEditujAuto f = new FormEditujAuto())
            {
                f.index = LBAuta.SelectedIndex;       f.ShowDialog();
            }
            LBAuta.Items.Clear();
            foreach( Auto a in Soubor.Auta)
            {
                LBAuta.Items.Add(a);
            }
        }
    }
}
