//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cs_bazy_comic
{
    using System;
    using System.Collections.Generic;
    
    public partial class orig_publishers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orig_publishers()
        {
            this.webtoons = new HashSet<webtoon>();
        }
    
        public int o_publisher_id { get; set; }
        public string name { get; set; }
        public string language { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<webtoon> webtoons { get; set; }
    }
}
