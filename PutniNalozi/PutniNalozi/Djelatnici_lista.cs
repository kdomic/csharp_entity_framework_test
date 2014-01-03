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
    public partial class Djelatnici_lista : Form
    {
        public Djelatnici_lista()
        {
            InitializeComponent();
            dgvOsobe.Dock = DockStyle.Fill;
        }

        private void Djelatnici_lista_Load(object sender, EventArgs e)
        {            
            BindingList<Osobe> listaOsoba = null;
            using(var db = new putni_naloziEntities())
            {
                listaOsoba = new BindingList<Osobe>(db.Osobe.ToList());
            }
            dgvOsobe.DataSource = listaOsoba;
        }

        private void dgvOsobe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = Int32.Parse(dgvOsobe.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }
            if (id > 0) Program.LoadForm(new Djelatnici_unos(id), this.MdiParent);            
        }
    }
}
