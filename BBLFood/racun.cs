
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
    
public partial class racun
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public racun()
    {

        this.racun_jelo = new HashSet<racun_jelo>();

    }


    public int id { get; set; }

    public System.DateTime datum_vrijeme { get; set; }

    public double iznos { get; set; }

    public Nullable<int> id_zaposlenik { get; set; }

    public string datum { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<racun_jelo> racun_jelo { get; set; }

    public virtual zaposlenik zaposlenik { get; set; }

}

}
