
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BBLFood
{

using System;
    using System.Collections.Generic;
    
public partial class zaposlenik
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public zaposlenik()
    {

        this.rezervacijas = new HashSet<rezervacija>();

        this.racuns = new HashSet<racun>();

    }


    public int id { get; set; }

    public string ime { get; set; }

    public string prezime { get; set; }

    public Nullable<int> id_radno_mjesto { get; set; }



    public virtual radno_mjesto radno_mjesto { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<rezervacija> rezervacijas { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<racun> racuns { get; set; }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

    }

}
