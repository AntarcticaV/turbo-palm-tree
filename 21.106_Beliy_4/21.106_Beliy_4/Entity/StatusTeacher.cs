//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _21._106_Beliy_4.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusTeacher
    {
        public StatusTeacher()
        {
            this.Teachers = new HashSet<Teachers>();
        }
    
        public int IdStatusTeacher { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Teachers> Teachers { get; set; }
    }
}
