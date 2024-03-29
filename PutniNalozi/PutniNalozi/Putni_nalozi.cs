//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PutniNalozi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Putni_nalozi
    {
        public Putni_nalozi()
        {
            this.Putni_racun = new HashSet<Putni_racun>();
        }
    
        public int idPutni_nalozi { get; set; }
        public int Vozila_idVozila { get; set; }
        public int Osobe_idOsobe { get; set; }
        public Nullable<System.DateTime> datum_start { get; set; }
        public Nullable<System.DateTime> datum_end { get; set; }
        public string adresa_puta { get; set; }
        public string mjesto_puta { get; set; }
        public string radno_mjesto { get; set; }
        public string zadaca { get; set; }
        public Nullable<int> idVozila { get; set; }
        public Nullable<double> trosak_puta { get; set; }
        public Nullable<double> predujam { get; set; }
        public System.DateTime datum_kreiranja { get; set; }
        public int idKreatora { get; set; }
        public string napomena { get; set; }
    
        public virtual Osobe Osobe { get; set; }
        public virtual Vozila Vozila { get; set; }
        public virtual ICollection<Putni_racun> Putni_racun { get; set; }
    }
}
