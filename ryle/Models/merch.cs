//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ryle.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class merch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public merch()
        {
            this.sostav = new HashSet<sostav>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string descreption { get; set; }
        public string detailproiz { get; set; }
        public int cost { get; set; }
        public Nullable<int> discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sostav> sostav { get; set; }
    }
}
