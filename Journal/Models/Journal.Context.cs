﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JournalEntities : DbContext
    {
        public JournalEntities()
            : base("name=JournalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Группа> Группа { get; set; }
        public virtual DbSet<Дисциплина> Дисциплина { get; set; }
        public virtual DbSet<Занятие> Занятие { get; set; }
        public virtual DbSet<Преподаватель> Преподаватель { get; set; }
        public virtual DbSet<Список> Список { get; set; }
        public virtual DbSet<Студент> Студент { get; set; }
        public virtual DbSet<Табель> Табель { get; set; }
    }
}
