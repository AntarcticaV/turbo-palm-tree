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
    
    public partial class StatusStudent
    {
        public StatusStudent()
        {
            this.Student = new HashSet<Student>();
        }
    
        public int IdStatusStudent { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Student> Student { get; set; }
    }
}
