
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PLUMAPPLICATION
{

using System;
    using System.Collections.Generic;
    
public partial class Farmer
{

    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string NameOfProduce { get; set; }

    public Nullable<int> TypeOfProduceId { get; set; }

    public string Quantity { get; set; }

    public Nullable<decimal> Price { get; set; }

    public Nullable<int> LocationId { get; set; }

    public Nullable<System.DateTime> DateAdded { get; set; }



    public virtual Location Location { get; set; }

    public virtual TypeOfProduce TypeOfProduce { get; set; }

}

}
