using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PutniNalozi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadForm(new Djelatnici_unos(),this);            
        }

        private void popisDjelatnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Program.LoadForm(new Djelatnici_lista(),this);            
        }

    }
}
