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
    
    public partial class Teachers
    {
        public Teachers()
        {
            this.Attestation = new HashSet<Attestation>();
            this.DisciplineTeachers = new HashSet<DisciplineTeachers>();
        }
    
        public int IdTeachers { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public int IdStatusTeachers { get; set; }
        public Nullable<int> IdRole { get; set; }
        public int IdSpeciality { get; set; }
    
        public virtual ICollection<Attestation> Attestation { get; set; }
        public virtual ICollection<DisciplineTeachers> DisciplineTeachers { get; set; }
        public virtual Role Role { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual StatusTeacher StatusTeacher { get; set; }
        public virtual SystemUser SystemUser { get; set; }
    }
}