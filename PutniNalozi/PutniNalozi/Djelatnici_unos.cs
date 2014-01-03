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
    public partial class Djelatnici_unos : Form
    {

        private Osobe osoba;
        private int id;

        public Djelatnici_unos(int _id=0)
        {
            InitializeComponent();
            id = _id;
            if(id>0)
            using(var db = new putni_naloziEntities())
            {
                osoba = (from o in db.Osobe where o.idOsobe == id select o).First<Osobe>();
                tbIme.Text = osoba.ime;
                tbPrezime.Text = osoba.prezime;
                tbOib.Text = osoba.oib;
                tbRodjenjeDatum.Text = osoba.rodjenje_datum.ToString();
                tbRodjenjeMjesto.Text = osoba.rodjenje_mjesto;
                tbPrebivalisteAdresa.Text = osoba.prebivaliste_adresa;
                tbPrebivalisteMjesto.Text = osoba.prebivaliste_mjesto;
            }
            tbIme.Focus();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (id == 0) osoba = new Osobe();
            osoba.ime = tbIme.Text;
            osoba.prezime = tbPrezime.Text;
            osoba.oib = tbOib.Text;
            osoba.rodjenje_datum = Convert.ToDateTime(tbRodjenjeDatum.Text);
            osoba.rodjenje_mjesto = tbRodjenjeMjesto.Text;
            osoba.prebivaliste_adresa = tbPrebivalisteAdresa.Text;
            osoba.prebivaliste_mjesto = tbPrebivalisteMjesto.Text;
            using(var db = new putni_naloziEntities())
            {
                if (id == 0) db.Osobe.Add(osoba);
                else
                {
                    db.Osobe.Attach(osoba);
                    db.Entry(osoba).State = EntityState.Modified;
                }
                db.SaveChanges();
            }            
            Program.LoadForm(new Djelatnici_lista(), this.MdiParent);
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Program.LoadForm(null, this.MdiParent);
            this.Close();            
        }
    }
}
