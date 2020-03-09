
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ScholarshipHub.Models
{

using System;
    using System.Collections.Generic;
    
public partial class OrganizationOffer
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public OrganizationOffer()
    {

        this.ApplicationsToOrganizations = new HashSet<ApplicationsToOrganization>();

    }


    public int id { get; set; }

    public string title { get; set; }

    public string degree { get; set; }

    public string startdate { get; set; }

    public string deadline { get; set; }

    public string percentage { get; set; }

    public string universityName { get; set; }

    public string totalseat { get; set; }

    public int organization_id { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ApplicationsToOrganization> ApplicationsToOrganizations { get; set; }

    public virtual Organisation Organisation { get; set; }

}

}