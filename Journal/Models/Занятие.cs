//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Journal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Занятие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Занятие()
        {
            this.Табель2 = new HashSet<Табель>();
        }
    
        public int Код_Занятия { get; set; }
        public Nullable<System.DateTime> Дата { get; set; }
        public string Тема { get; set; }
        public string Домашнее_задание { get; set; }
        public Nullable<int> Группа { get; set; }
        public Nullable<int> Преподаватель { get; set; }
        public Nullable<int> Дисциплина { get; set; }
        public Nullable<int> Табель { get; set; }
    
        public virtual Группа Группа1 { get; set; }
        public virtual Дисциплина Дисциплина1 { get; set; }
        public virtual Преподаватель Преподаватель1 { get; set; }
        public virtual Табель Табель1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Табель> Табель2 { get; set; }
    }
}
