
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
    
public partial class jelovnik_jelo
{

    public int id_jelovnik { get; set; }

    public int id_jelo { get; set; }

    public Nullable<int> kolicina { get; set; }



    public virtual jelo jelo { get; set; }

    public virtual jelovnik jelovnik { get; set; }

}

}
