
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
    
public partial class jelo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public jelo()
    {

        this.racun_jelo = new HashSet<racun_jelo>();

        this.jelovnik_jelo = new HashSet<jelovnik_jelo>();

        this.sastojaks = new HashSet<sastojak>();

    }


    public int id { get; set; }

    public string naziv { get; set; }

    public string vrsta { get; set; }

    public Nullable<double> cijena { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<racun_jelo> racun_jelo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<jelovnik_jelo> jelovnik_jelo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<sastojak> sastojaks { get; set; }
        public override string ToString()
        {
            return naziv;
        }

    }

}
